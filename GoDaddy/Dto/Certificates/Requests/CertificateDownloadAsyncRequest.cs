using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateDownloadAsyncRequest
{
    public string CertificateId { get; }

    public CertificateDownloadAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
