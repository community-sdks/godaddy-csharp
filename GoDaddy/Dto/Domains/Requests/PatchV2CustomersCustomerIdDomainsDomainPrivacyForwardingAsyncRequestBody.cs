namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody
{
    public string PrivateEmailType { get; }
    public string? ForwardingEmail { get; }
    public string EmailPreference { get; }

    public PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody(
        string PrivateEmailType,
        string? ForwardingEmail,
        string EmailPreference
    )
    {
        this.PrivateEmailType = PrivateEmailType;
        this.ForwardingEmail = ForwardingEmail;
        this.EmailPreference = EmailPreference;
    }
}
