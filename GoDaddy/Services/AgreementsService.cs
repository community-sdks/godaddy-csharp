using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AgreementsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AgreementsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> GetAsync(object Keys, object? XPrivateLabelId, object? XMarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agreements",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("keys", Keys),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Private-Label-Id", XPrivateLabelId),
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            null,
            cancellationToken);
    }
}
