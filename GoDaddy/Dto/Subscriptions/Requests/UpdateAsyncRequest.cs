
namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class UpdateAsyncRequest
{
    public string XAppKey { get; }
    public string? XShopperId { get; }
    public string SubscriptionId { get; }
    public UpdateAsyncRequestSubscription Subscription { get; }

    public UpdateAsyncRequest(
        string XAppKey,
        string? XShopperId,
        string SubscriptionId,
        UpdateAsyncRequestSubscription Subscription
    )
    {
        this.XAppKey = XAppKey;
        this.XShopperId = XShopperId;
        this.SubscriptionId = SubscriptionId;
        this.Subscription = Subscription;
    }
}
