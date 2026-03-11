using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateGetAsyncRequest
{
    public string CertificateId { get; }

    public CertificateGetAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
