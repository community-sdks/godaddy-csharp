using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class OrdersService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public OrdersService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> ListAsync(object XAppKey, object? PeriodStart, object? PeriodEnd, object? Domain, object? ProductGroupId, object? PaymentProfileId, object? ParentOrderId, object? Offset, object? Limit, object? Sort, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/orders",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("periodStart", PeriodStart),
            new KeyValuePair<string, object?>("periodEnd", PeriodEnd),
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("productGroupId", ProductGroupId),
            new KeyValuePair<string, object?>("paymentProfileId", PaymentProfileId),
            new KeyValuePair<string, object?>("parentOrderId", ParentOrderId),
            new KeyValuePair<string, object?>("offset", Offset),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("sort", Sort),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAsync(object OrderId, object XAppKey, object? XShopperId, object? XMarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/orders/{orderId}",
            new[]
        {
            new KeyValuePair<string, object?>("orderId", OrderId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
        },
            null,
            cancellationToken);
    }
}
