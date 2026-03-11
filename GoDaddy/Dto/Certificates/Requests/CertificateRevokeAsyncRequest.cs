
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateRevokeAsyncRequest
{
    public string CertificateId { get; }
    public CertificateRevokeAsyncRequestCertificateRevoke CertificateRevoke { get; }

    public CertificateRevokeAsyncRequest(
        string CertificateId,
        CertificateRevokeAsyncRequestCertificateRevoke CertificateRevoke
    )
    {
        this.CertificateId = CertificateId;
        this.CertificateRevoke = CertificateRevoke;
    }
}
