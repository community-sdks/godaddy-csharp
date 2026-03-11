using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateResendEmailAsyncRequest
{
    public string CertificateId { get; }
    public string EmailId { get; }

    public CertificateResendEmailAsyncRequest(
        string CertificateId,
        string EmailId
    )
    {
        this.CertificateId = CertificateId;
        this.EmailId = EmailId;
    }
}
