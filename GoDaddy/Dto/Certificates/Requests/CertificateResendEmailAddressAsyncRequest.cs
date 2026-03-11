using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateResendEmailAddressAsyncRequest
{
    public string CertificateId { get; }
    public string EmailId { get; }
    public string EmailAddress { get; }

    public CertificateResendEmailAddressAsyncRequest(
        string CertificateId,
        string EmailId,
        string EmailAddress
    )
    {
        this.CertificateId = CertificateId;
        this.EmailId = EmailId;
        this.EmailAddress = EmailAddress;
    }
}
