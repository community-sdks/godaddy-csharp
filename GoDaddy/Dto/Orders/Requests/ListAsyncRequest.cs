using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Orders.Requests;

public sealed class ListAsyncRequest
{
    public string? PeriodStart { get; }
    public string? PeriodEnd { get; }
    public string? Domain { get; }
    public int? ProductGroupId { get; }
    public int? PaymentProfileId { get; }
    public string? ParentOrderId { get; }
    public int? Offset { get; }
    public int? Limit { get; }
    public string? Sort { get; }
    public string? XShopperId { get; }
    public string XAppKey { get; }

    public ListAsyncRequest(
        string? PeriodStart,
        string? PeriodEnd,
        string? Domain,
        int? ProductGroupId,
        int? PaymentProfileId,
        string? ParentOrderId,
        int? Offset,
        int? Limit,
        string? Sort,
        string? XShopperId,
        string XAppKey
    )
    {
        this.PeriodStart = PeriodStart;
        this.PeriodEnd = PeriodEnd;
        this.Domain = Domain;
        this.ProductGroupId = ProductGroupId;
        this.PaymentProfileId = PaymentProfileId;
        this.ParentOrderId = ParentOrderId;
        this.Offset = Offset;
        this.Limit = Limit;
        this.Sort = Sort;
        this.XShopperId = XShopperId;
        this.XAppKey = XAppKey;
    }
}
