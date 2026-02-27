using System.Text;
using System.Text.Json;

namespace CommunitySdks.GoDaddy.Http;

public sealed class HttpClientTransport : ITransport
{
    private readonly HttpClient _httpClient;

    public HttpClientTransport(HttpClient? httpClient = null)
    {
        _httpClient = httpClient ?? new HttpClient();
    }

    public async Task<HttpResponse> SendAsync(HttpRequest request, CancellationToken cancellationToken = default)
    {
        using var message = new HttpRequestMessage(new HttpMethod(request.Method), request.FullUrl());
        foreach (var header in request.Headers)
        {
            if (!message.Headers.TryAddWithoutValidation(header.Key, header.Value))
            {
                message.Content ??= new StringContent(string.Empty);
                message.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }
        if (request.Body is not null)
        {
            var content = request.Body is string text ? text : JsonSerializer.Serialize(request.Body);
            message.Content = new StringContent(content, Encoding.UTF8, "application/json");
        }
        using var timeoutSource = new CancellationTokenSource(request.Timeout);
        using var linkedSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutSource.Token);
        using var response = await _httpClient.SendAsync(message, linkedSource.Token).ConfigureAwait(false);
        var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var header in response.Headers) headers[header.Key] = string.Join(",", header.Value);
        if (response.Content is not null) foreach (var header in response.Content.Headers) headers[header.Key] = string.Join(",", header.Value);
        return new HttpResponse { StatusCode = (int)response.StatusCode, Headers = headers, Body = response.Content is null ? string.Empty : await response.Content.ReadAsStringAsync(linkedSource.Token).ConfigureAwait(false) };
    }
}
