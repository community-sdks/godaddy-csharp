using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateSitesealGetAsyncRequest
{
    public string CertificateId { get; }
    public string? Theme { get; }
    public string? Locale { get; }

    public CertificateSitesealGetAsyncRequest(
        string CertificateId,
        string? Theme,
        string? Locale
    )
    {
        this.CertificateId = CertificateId;
        this.Theme = Theme;
        this.Locale = Locale;
    }
}
