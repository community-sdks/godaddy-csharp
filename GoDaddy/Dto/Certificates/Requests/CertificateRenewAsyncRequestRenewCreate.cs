namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateRenewAsyncRequestRenewCreate
{
    public string? CallbackUrl { get; }
    public string? CommonName { get; }
    public string? Csr { get; }
    public int? Period { get; }
    public string? RootType { get; }
    public IReadOnlyList<string>? SubjectAlternativeNames { get; }

    public CertificateRenewAsyncRequestRenewCreate(
        string? CallbackUrl,
        string? CommonName,
        string? Csr,
        int? Period,
        string? RootType,
        IReadOnlyList<string>? SubjectAlternativeNames
    )
    {
        this.CallbackUrl = CallbackUrl;
        this.CommonName = CommonName;
        this.Csr = Csr;
        this.Period = Period;
        this.RootType = RootType;
        this.SubjectAlternativeNames = SubjectAlternativeNames;
    }
}
