using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class GetAsyncRequest
{
    public string XAppKey { get; }
    public string? XShopperId { get; }
    public string SubscriptionId { get; }

    public GetAsyncRequest(
        string XAppKey,
        string? XShopperId,
        string SubscriptionId
    )
    {
        this.XAppKey = XAppKey;
        this.XShopperId = XShopperId;
        this.SubscriptionId = SubscriptionId;
    }
}
