namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBodyConsent
{
    public int Price { get; }
    public string Currency { get; }
    public bool? RegistryPremiumPricing { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }

    public PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBodyConsent(
        int Price,
        string Currency,
        bool? RegistryPremiumPricing,
        string AgreedBy,
        string AgreedAt
    )
    {
        this.Price = Price;
        this.Currency = Currency;
        this.RegistryPremiumPricing = RegistryPremiumPricing;
        this.AgreedBy = AgreedBy;
        this.AgreedAt = AgreedAt;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody
{
    public string Expires { get; }
    public PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBodyConsent Consent { get; }
    public int? Period { get; }

    public PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody(
        string Expires,
        PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBodyConsent Consent,
        int? Period
    )
    {
        this.Expires = Expires;
        this.Consent = Consent;
        this.Period = Period;
    }
}
