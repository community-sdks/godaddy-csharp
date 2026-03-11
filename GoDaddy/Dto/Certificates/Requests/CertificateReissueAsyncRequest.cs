
namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateReissueAsyncRequest
{
    public string CertificateId { get; }
    public CertificateReissueAsyncRequestReissueCreate ReissueCreate { get; }

    public CertificateReissueAsyncRequest(
        string CertificateId,
        CertificateReissueAsyncRequestReissueCreate ReissueCreate
    )
    {
        this.CertificateId = CertificateId;
        this.ReissueCreate = ReissueCreate;
    }
}
