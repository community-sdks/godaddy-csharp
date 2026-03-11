using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class RetrieveSslByDomainResellerAsyncRequest
{
    public string? Param1 { get; }
    public string? Param2 { get; }
    public string? Param3 { get; }
    public string? Param4 { get; }
    public string? Param5 { get; }
    public string? Param6 { get; }

    public RetrieveSslByDomainResellerAsyncRequest(
        string? Param1,
        string? Param2,
        string? Param3,
        string? Param4,
        string? Param5,
        string? Param6
    )
    {
        this.Param1 = Param1;
        this.Param2 = Param2;
        this.Param3 = Param3;
        this.Param4 = Param4;
        this.Param5 = Param5;
        this.Param6 = Param6;
    }
}
