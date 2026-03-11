using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCancelAsyncRequest
{
    public string CertificateId { get; }

    public CertificateCancelAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
