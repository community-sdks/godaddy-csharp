using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class GetDomainInformationByCertificateIdAsyncRequest
{
    public string? Param1 { get; }
    public string? Param2 { get; }

    public GetDomainInformationByCertificateIdAsyncRequest(
        string? Param1,
        string? Param2
    )
    {
        this.Param1 = Param1;
        this.Param2 = Param2;
    }
}
