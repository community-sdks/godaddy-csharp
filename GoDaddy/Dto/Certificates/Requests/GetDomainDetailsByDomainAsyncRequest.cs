using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class GetDomainDetailsByDomainAsyncRequest
{
    public string? Param1 { get; }
    public string? Param2 { get; }
    public string? Param3 { get; }

    public GetDomainDetailsByDomainAsyncRequest(
        string? Param1,
        string? Param2,
        string? Param3
    )
    {
        this.Param1 = Param1;
        this.Param2 = Param2;
        this.Param3 = Param3;
    }
}
