using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class GetCertificateDetailByCertIdentifierAsyncRequest
{
    public string? Param1 { get; }
    public string? Param2 { get; }

    public GetCertificateDetailByCertIdentifierAsyncRequest(
        string? Param1,
        string? Param2
    )
    {
        this.Param1 = Param1;
        this.Param2 = Param2;
    }
}
