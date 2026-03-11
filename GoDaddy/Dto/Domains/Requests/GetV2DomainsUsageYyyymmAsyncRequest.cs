using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2DomainsUsageYyyymmAsyncRequest
{
    public string? XRequestId { get; }
    public string Yyyymm { get; }
    public IReadOnlyList<string>? Includes { get; }

    public GetV2DomainsUsageYyyymmAsyncRequest(
        string? XRequestId,
        string Yyyymm,
        IReadOnlyList<string>? Includes
    )
    {
        this.XRequestId = XRequestId;
        this.Yyyymm = Yyyymm;
        this.Includes = Includes;
    }
}
