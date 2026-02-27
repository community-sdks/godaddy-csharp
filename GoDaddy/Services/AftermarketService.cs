using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AftermarketService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AftermarketService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> GetListingsAsync(object CustomerId, object? Domains, object? ListingStatus, object? TransferBefore, object? TransferAfter, object? Limit, object? Offset, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/customers/{customerId}/auctions/listings",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("domains", Domains),
            new KeyValuePair<string, object?>("listingStatus", ListingStatus),
            new KeyValuePair<string, object?>("transferBefore", TransferBefore),
            new KeyValuePair<string, object?>("transferAfter", TransferAfter),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DeleteListingsAsync(object Domains, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/aftermarket/listings",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("domains", Domains),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> AddExpiryListingsAsync(object ExpiryListings, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/aftermarket/listings/expiry",
            null,
            null,
            null,
            ExpiryListings,
            cancellationToken);
    }
}
