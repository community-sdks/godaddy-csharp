using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public abstract class AbstractService
{
    protected AbstractService(ApiClient client, string baseUrl)
    {
        Client = client;
        BaseUrl = baseUrl;
    }

    protected ApiClient Client { get; }
    protected string BaseUrl { get; }

    protected Task<JsonNode?> CallAsync(string method, string path, IEnumerable<KeyValuePair<string, object?>>? pathParams = null, IEnumerable<KeyValuePair<string, object?>>? queryParams = null, IEnumerable<KeyValuePair<string, object?>>? headers = null, object? body = null, CancellationToken cancellationToken = default) => Client.RequestAsync(method, BaseUrl, path, pathParams, queryParams, headers, body, cancellationToken);
}
