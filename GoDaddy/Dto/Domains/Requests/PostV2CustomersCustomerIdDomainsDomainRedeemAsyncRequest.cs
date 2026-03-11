
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
