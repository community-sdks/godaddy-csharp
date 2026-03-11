using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Parking.Requests;

public sealed class GetMetricsByDomainAsyncRequest
{
    public string CustomerId { get; }
    public string StartDate { get; }
    public string EndDate { get; }
    public string? Domains { get; }
    public string? DomainLike { get; }
    public string? PortfolioId { get; }
    public int? Limit { get; }
    public int? Offset { get; }
    public string? XRequestId { get; }

    public GetMetricsByDomainAsyncRequest(
        string CustomerId,
        string StartDate,
        string EndDate,
        string? Domains,
        string? DomainLike,
        string? PortfolioId,
        int? Limit,
        int? Offset,
        string? XRequestId
    )
    {
        this.CustomerId = CustomerId;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Domains = Domains;
        this.DomainLike = DomainLike;
        this.PortfolioId = PortfolioId;
        this.Limit = Limit;
        this.Offset = Offset;
        this.XRequestId = XRequestId;
    }
}
