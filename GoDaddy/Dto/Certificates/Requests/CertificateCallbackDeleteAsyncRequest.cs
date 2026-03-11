using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCallbackDeleteAsyncRequest
{
    public string CertificateId { get; }

    public CertificateCallbackDeleteAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
