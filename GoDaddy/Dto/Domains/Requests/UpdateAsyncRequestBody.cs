namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class UpdateAsyncRequestBodyConsent
{
    public string AgreedAt { get; }
    public string AgreedBy { get; }
    public IReadOnlyList<string> AgreementKeys { get; }

    public UpdateAsyncRequestBodyConsent(
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

public sealed class UpdateAsyncRequestBody
{
    public bool? Locked { get; }
    public IReadOnlyList<string>? NameServers { get; }
    public bool? RenewAuto { get; }
    public string? SubaccountId { get; }
    public bool? ExposeRegistrantOrganization { get; }
    public bool? ExposeWhois { get; }
    public UpdateAsyncRequestBodyConsent? Consent { get; }

    public UpdateAsyncRequestBody(
        bool? Locked,
        IReadOnlyList<string>? NameServers,
        bool? RenewAuto,
        string? SubaccountId,
        bool? ExposeRegistrantOrganization,
        bool? ExposeWhois,
        UpdateAsyncRequestBodyConsent? Consent
    )
    {
        this.Locked = Locked;
        this.NameServers = NameServers;
        this.RenewAuto = RenewAuto;
        this.SubaccountId = SubaccountId;
        this.ExposeRegistrantOrganization = ExposeRegistrantOrganization;
        this.ExposeWhois = ExposeWhois;
        this.Consent = Consent;
    }
}
