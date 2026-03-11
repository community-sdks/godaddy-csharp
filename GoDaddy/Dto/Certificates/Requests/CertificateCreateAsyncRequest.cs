
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCreateAsyncRequest
{
    public string? XMarketId { get; }
    public CertificateCreateAsyncRequestCertificateCreate CertificateCreate { get; }

    public CertificateCreateAsyncRequest(
        string? XMarketId,
        CertificateCreateAsyncRequestCertificateCreate CertificateCreate
    )
    {
        this.XMarketId = XMarketId;
        this.CertificateCreate = CertificateCreate;
    }
}
