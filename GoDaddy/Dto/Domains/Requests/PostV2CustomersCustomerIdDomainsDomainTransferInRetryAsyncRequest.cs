
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
