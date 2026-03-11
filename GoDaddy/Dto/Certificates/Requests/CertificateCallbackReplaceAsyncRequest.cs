using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateCallbackReplaceAsyncRequest
{
    public string CertificateId { get; }
    public string CallbackUrl { get; }

    public CertificateCallbackReplaceAsyncRequest(
        string CertificateId,
        string CallbackUrl
    )
    {
        this.CertificateId = CertificateId;
        this.CallbackUrl = CallbackUrl;
    }
}
