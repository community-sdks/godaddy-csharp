namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateReissueAsyncRequestReissueCreate
{
    public string? CallbackUrl { get; }
    public string? CommonName { get; }
    public string? Csr { get; }
    public int? DelayExistingRevoke { get; }
    public string? RootType { get; }
    public IReadOnlyList<string>? SubjectAlternativeNames { get; }
    public IReadOnlyList<string>? ForceDomainRevetting { get; }

    public CertificateReissueAsyncRequestReissueCreate(
        string? CallbackUrl,
        string? CommonName,
        string? Csr,
        int? DelayExistingRevoke,
        string? RootType,
        IReadOnlyList<string>? SubjectAlternativeNames,
        IReadOnlyList<string>? ForceDomainRevetting
    )
    {
        this.CallbackUrl = CallbackUrl;
        this.CommonName = CommonName;
        this.Csr = Csr;
        this.DelayExistingRevoke = DelayExistingRevoke;
        this.RootType = RootType;
        this.SubjectAlternativeNames = SubjectAlternativeNames;
        this.ForceDomainRevetting = ForceDomainRevetting;
    }
}
