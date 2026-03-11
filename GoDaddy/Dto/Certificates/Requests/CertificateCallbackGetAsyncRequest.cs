using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCallbackGetAsyncRequest
{
    public string CertificateId { get; }

    public CertificateCallbackGetAsyncRequest(
        string CertificateId
    )
    {
        this.CertificateId = CertificateId;
    }
}
