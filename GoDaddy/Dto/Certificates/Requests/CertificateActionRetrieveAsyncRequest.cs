using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateActionRetrieveAsyncRequest
{
    public string CertificateId { get; }

    public CertificateActionRetrieveAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
