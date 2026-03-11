using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateDownloadEntitlementAsyncRequest
{
    public string EntitlementId { get; }

    public CertificateDownloadEntitlementAsyncRequest(
        string EntitlementId
    )
    {
        this.EntitlementId = EntitlementId;
    }
}
