
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody Body { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequest(
        string? XRequestId,
        string CustomerId,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Body = Body;
    }
}
