using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AuctionsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AuctionsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> PlaceBidsAsync(object CustomerId, object RequestBody, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/customers/{customerId}/aftermarket/listings/bids",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            null,
            RequestBody,
            cancellationToken);
    }
}
