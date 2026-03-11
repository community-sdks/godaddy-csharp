namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PurchasePrivacyAsyncRequestBodyConsent
{
    public string AgreedAt { get; }
    public string AgreedBy { get; }
    public IReadOnlyList<string> AgreementKeys { get; }

    public PurchasePrivacyAsyncRequestBodyConsent(
        string AgreedAt,
        string AgreedBy,
        IReadOnlyList<string> AgreementKeys
    )
    {
        this.AgreedAt = AgreedAt;
        this.AgreedBy = AgreedBy;
        this.AgreementKeys = AgreementKeys;
    }
}

public sealed class PurchasePrivacyAsyncRequestBody
{
    public PurchasePrivacyAsyncRequestBodyConsent Consent { get; }

    public PurchasePrivacyAsyncRequestBody(
        PurchasePrivacyAsyncRequestBodyConsent Consent
    )
    {
        this.Consent = Consent;
    }
}
