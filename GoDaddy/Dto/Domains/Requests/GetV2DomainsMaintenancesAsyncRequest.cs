using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2DomainsMaintenancesAsyncRequest
{
    public string? XRequestId { get; }
    public string? Status { get; }
    public string? ModifiedAtAfter { get; }
    public string? StartsAtAfter { get; }
    public int? Limit { get; }

    public GetV2DomainsMaintenancesAsyncRequest(
        string? XRequestId,
        string? Status,
        string? ModifiedAtAfter,
        string? StartsAtAfter,
        int? Limit
    )
    {
        this.XRequestId = XRequestId;
        this.Status = Status;
        this.ModifiedAtAfter = ModifiedAtAfter;
        this.StartsAtAfter = StartsAtAfter;
        this.Limit = Limit;
    }
}
