
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateValidateAsyncRequest
{
    public string? XMarketId { get; }
    public CertificateValidateAsyncRequestCertificateCreate CertificateCreate { get; }

    public CertificateValidateAsyncRequest(
        string? XMarketId,
        CertificateValidateAsyncRequestCertificateCreate CertificateCreate
    )
    {
        this.XMarketId = XMarketId;
        this.CertificateCreate = CertificateCreate;
    }
}
