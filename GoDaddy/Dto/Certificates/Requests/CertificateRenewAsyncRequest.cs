
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateRenewAsyncRequest
{
    public string CertificateId { get; }
    public CertificateRenewAsyncRequestRenewCreate RenewCreate { get; }

    public CertificateRenewAsyncRequest(
        string CertificateId,
        CertificateRenewAsyncRequestRenewCreate RenewCreate
    )
    {
        this.CertificateId = CertificateId;
        this.RenewCreate = RenewCreate;
    }
}
