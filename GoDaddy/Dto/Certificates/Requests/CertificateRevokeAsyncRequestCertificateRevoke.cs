namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateRevokeAsyncRequestCertificateRevoke
{
    public string Reason { get; }

    public CertificateRevokeAsyncRequestCertificateRevoke(
        string Reason
    )
    {
        this.Reason = Reason;
    }
}
