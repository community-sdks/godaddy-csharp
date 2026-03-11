using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateEmailHistoryAsyncRequest
{
    public string CertificateId { get; }

    public CertificateEmailHistoryAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
