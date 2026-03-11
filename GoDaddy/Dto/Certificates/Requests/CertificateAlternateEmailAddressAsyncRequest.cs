using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateAlternateEmailAddressAsyncRequest
{
    public string CertificateId { get; }
    public string EmailAddress { get; }

    public CertificateAlternateEmailAddressAsyncRequest(
        string CertificateId,
        string EmailAddress
    )
    {
        this.CertificateId = CertificateId;
        this.EmailAddress = EmailAddress;
    }
}
