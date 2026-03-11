using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class CancelAsyncRequest
{
    public string XAppKey { get; }
    public string? XShopperId { get; }
    public string SubscriptionId { get; }

    public CancelAsyncRequest(
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
