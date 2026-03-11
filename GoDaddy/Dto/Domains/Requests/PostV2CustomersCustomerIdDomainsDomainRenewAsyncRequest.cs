
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
