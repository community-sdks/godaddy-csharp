using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class SubscriptionsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public SubscriptionsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> ListAsync(object XAppKey, object? XShopperId, object? XMarketId, object? ProductGroupKeys, object? Includes, object? Offset, object? Limit, object? Sort, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/subscriptions",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("productGroupKeys", ProductGroupKeys),
            new KeyValuePair<string, object?>("includes", Includes),
            new KeyValuePair<string, object?>("offset", Offset),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("sort", Sort),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> ProductGroupsAsync(object XAppKey, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/subscriptions/productGroups",
            null,
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CancelAsync(object SubscriptionId, object XAppKey, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/subscriptions/{subscriptionId}",
            new[]
        {
            new KeyValuePair<string, object?>("subscriptionId", SubscriptionId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAsync(object SubscriptionId, object XAppKey, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/subscriptions/{subscriptionId}",
            new[]
        {
            new KeyValuePair<string, object?>("subscriptionId", SubscriptionId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> UpdateAsync(object SubscriptionId, object XAppKey, object Subscription, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v1/subscriptions/{subscriptionId}",
            new[]
        {
            new KeyValuePair<string, object?>("subscriptionId", SubscriptionId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-App-Key", XAppKey),
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Subscription,
            cancellationToken);
    }
}
