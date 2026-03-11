using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Parking.Requests;

public sealed class GetMetricsAsyncRequest
{
    public string CustomerId { get; }
    public string? PeriodStartPtz { get; }
    public string? PeriodEndPtz { get; }
    public int? Limit { get; }
    public int? Offset { get; }
    public string? XRequestId { get; }

    public GetMetricsAsyncRequest(
        string CustomerId,
        string? PeriodStartPtz,
        string? PeriodEndPtz,
        int? Limit,
        int? Offset,
        string? XRequestId
    )
    {
        this.CustomerId = CustomerId;
        this.PeriodStartPtz = PeriodStartPtz;
        this.PeriodEndPtz = PeriodEndPtz;
        this.Limit = Limit;
        this.Offset = Offset;
        this.XRequestId = XRequestId;
    }
}
