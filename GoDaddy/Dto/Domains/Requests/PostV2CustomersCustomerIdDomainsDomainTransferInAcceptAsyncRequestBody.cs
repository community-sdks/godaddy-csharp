namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody
{
    public string AuthCode { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody(
        string AuthCode
    )
    {
        this.AuthCode = AuthCode;
    }
}
