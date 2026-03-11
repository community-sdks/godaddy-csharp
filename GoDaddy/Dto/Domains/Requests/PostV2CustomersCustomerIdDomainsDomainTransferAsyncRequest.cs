
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
