
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequest(
        string? XRequestId,
        string CustomerId,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Body = Body;
    }
}
