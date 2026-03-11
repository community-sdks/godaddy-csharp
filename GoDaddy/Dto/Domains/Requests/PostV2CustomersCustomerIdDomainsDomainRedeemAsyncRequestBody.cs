namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBodyConsent
{
    public int Price { get; }
    public int Fee { get; }
    public string Currency { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }

    public PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBodyConsent(
        int Price,
        int Fee,
        string Currency,
        string AgreedBy,
        string AgreedAt
    )
    {
        this.Price = Price;
        this.Fee = Fee;
        this.Currency = Currency;
        this.AgreedBy = AgreedBy;
        this.AgreedAt = AgreedAt;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody
{
    public PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBodyConsent Consent { get; }

    public PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody(
        PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBodyConsent Consent
    )
    {
        this.Consent = Consent;
    }
}
