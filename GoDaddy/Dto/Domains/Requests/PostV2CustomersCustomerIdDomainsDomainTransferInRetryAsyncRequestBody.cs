namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody
{
    public string AuthCode { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody(
        string AuthCode
    )
    {
        this.AuthCode = AuthCode;
    }
}
