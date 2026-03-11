using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateGetEntitlementAsyncRequest
{
    public string EntitlementId { get; }
    public bool? Latest { get; }

    public CertificateGetEntitlementAsyncRequest(
        string EntitlementId,
        bool? Latest
    )
    {
        this.EntitlementId = EntitlementId;
        this.Latest = Latest;
    }
}
