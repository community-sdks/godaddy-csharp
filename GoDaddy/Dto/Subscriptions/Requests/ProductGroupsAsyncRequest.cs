using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class ProductGroupsAsyncRequest
{
    public string XAppKey { get; }
    public string? XShopperId { get; }

    public ProductGroupsAsyncRequest(
        string XAppKey,
        string? XShopperId
    )
    {
        this.XAppKey = XAppKey;
        this.XShopperId = XShopperId;
    }
}
