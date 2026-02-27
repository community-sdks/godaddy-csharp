using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Http;

namespace CommunitySdks.GoDaddy;

public sealed class ApiClient
{
    private readonly Config _config;
    private readonly ITransport _transport;

    public ApiClient(Config config, ITransport? transport = null)
    {
        _config = config;
        _transport = transport ?? new HttpClientTransport();
    }

    public static IReadOnlyList<KeyValuePair<string, string>> BuildQueryPairs(IEnumerable<KeyValuePair<string, object?>> values)
    {
        var pairs = new List<KeyValuePair<string, string>>();
        foreach (var pair in values)
        {
            if (pair.Value is null) continue;
            if (pair.Value is string) { pairs.Add(new(pair.Key, Stringify(pair.Value))); continue; }
            if (pair.Value is System.Collections.IEnumerable sequence)
            {
                foreach (var item in sequence) if (item is not null) pairs.Add(new(pair.Key, Stringify(item)));
                continue;
            }
            pairs.Add(new(pair.Key, Stringify(pair.Value)));
        }
        return pairs;
    }

    public async Task<JsonNode?> RequestAsync(string method, string serviceBaseUrl, string path, IEnumerable<KeyValuePair<string, object?>>? pathParams = null, IEnumerable<KeyValuePair<string, object?>>? queryParams = null, IEnumerable<KeyValuePair<string, object?>>? headers = null, object? body = null, CancellationToken cancellationToken = default)
    {
        var request = new HttpRequest
        {
            Method = method,
            Url = $"{(_config.BaseUrl ?? serviceBaseUrl).TrimEnd('/')}{InterpolatePath(path, pathParams)}",
            Headers = BuildHeaders(headers, body),
            Query = BuildQueryPairs(queryParams ?? Array.Empty<KeyValuePair<string, object?>>()),
            Body = body,
            Timeout = _config.Timeout
        };
        var response = await SendWithRetryAsync(request, cancellationToken).ConfigureAwait(false);
        if (response.StatusCode is < 200 or >= 300) throw MapException(request, response);
        return DecodeResponse(response);
    }

    private async Task<HttpResponse> SendWithRetryAsync(HttpRequest request, CancellationToken cancellationToken)
    {
        var attempt = 0;
        while (true)
        {
            var response = await _transport.SendAsync(request, cancellationToken).ConfigureAwait(false);
            if (!ShouldRetry(response.StatusCode, attempt)) return response;
            await Task.Delay(TimeSpan.FromMilliseconds(_config.RetryDelay.TotalMilliseconds * Math.Pow(2, attempt)), cancellationToken).ConfigureAwait(false);
            attempt++;
        }
    }

    private bool ShouldRetry(int statusCode, int attempt) => attempt < _config.MaxRetries && (statusCode is 408 or 429 or 500 or 502 or 503 or 504);

    private IReadOnlyDictionary<string, string> BuildHeaders(IEnumerable<KeyValuePair<string, object?>>? headers, object? body)
    {
        var resolved = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { ["Accept"] = "application/json", ["User-Agent"] = _config.UserAgent };
        foreach (var header in _config.DefaultHeaders) resolved[header.Key] = header.Value;
        if (headers is not null) foreach (var header in headers) if (header.Value is not null) resolved[header.Key] = Stringify(header.Value);
        if (!string.IsNullOrWhiteSpace(_config.ApiKey) && !string.IsNullOrWhiteSpace(_config.ApiSecret)) resolved["Authorization"] = $"sso-key {_config.ApiKey}:{_config.ApiSecret}";
        if (body is not null && !resolved.ContainsKey("Content-Type")) resolved["Content-Type"] = "application/json";
        return resolved;
    }

    private static string InterpolatePath(string path, IEnumerable<KeyValuePair<string, object?>>? pathParams)
    {
        var resolved = path;
        if (pathParams is null) return resolved;
        foreach (var pair in pathParams) if (pair.Value is not null) resolved = resolved.Replace($"{{{pair.Key}}}", Uri.EscapeDataString(Stringify(pair.Value)), StringComparison.Ordinal);
        return resolved;
    }

    private static JsonNode? DecodeResponse(HttpResponse response)
    {
        if (string.IsNullOrWhiteSpace(response.Body)) return null;
        var contentType = response.Headers.TryGetValue("content-type", out var lower) ? lower : response.Headers.TryGetValue("Content-Type", out var upper) ? upper : string.Empty;
        var trimmed = response.Body.TrimStart();
        if (contentType.Contains("json", StringComparison.OrdinalIgnoreCase) || trimmed.StartsWith("{") || trimmed.StartsWith("["))
        {
            try { return JsonNode.Parse(response.Body); } catch { return JsonValue.Create(response.Body); }
        }
        return JsonValue.Create(response.Body);
    }

    private static string Stringify(object? value) => value switch
    {
        null => string.Empty,
        bool boolean => boolean ? "true" : "false",
        JsonNode node => node.ToJsonString(),
        string text => text,
        _ => value.ToString() ?? string.Empty
    };

    private static ApiException MapException(HttpRequest request, HttpResponse response)
    {
        var message = $"GoDaddy API request failed with status {response.StatusCode}";
        return response.StatusCode switch
        {
            400 => new ValidationException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl()),
            401 or 403 => new UnauthorizedException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl()),
            404 => new NotFoundException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl()),
            429 => new RateLimitException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl()),
            >= 500 => new ServerException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl()),
            _ => new ApiException(message, response.StatusCode, response.Body, response.Headers, request.Method, request.FullUrl())
        };
    }
}
