
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
