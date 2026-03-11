using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Orders.Requests;

public sealed class GetAsyncRequest
{
    public string OrderId { get; }
    public string? XShopperId { get; }
    public string? XMarketId { get; }
    public string XAppKey { get; }

    public GetAsyncRequest(
        string OrderId,
        string? XShopperId,
        string? XMarketId,
        string XAppKey
    )
    {
        this.OrderId = OrderId;
        this.XShopperId = XShopperId;
        this.XMarketId = XMarketId;
        this.XAppKey = XAppKey;
    }
}
