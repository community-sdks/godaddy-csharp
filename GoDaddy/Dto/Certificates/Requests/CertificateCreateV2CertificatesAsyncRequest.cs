
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCreateV2CertificatesAsyncRequest
{
    public string? XMarketId { get; }
    public CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreate SubscriptionCertificateCreate { get; }

    public CertificateCreateV2CertificatesAsyncRequest(
        string? XMarketId,
        CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreate SubscriptionCertificateCreate
    )
    {
        this.XMarketId = XMarketId;
        this.SubscriptionCertificateCreate = SubscriptionCertificateCreate;
    }
}
