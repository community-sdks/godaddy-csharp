using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateVerifydomaincontrolAsyncRequest
{
    public string CertificateId { get; }

    public CertificateVerifydomaincontrolAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
