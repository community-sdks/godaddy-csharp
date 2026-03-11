
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody Body { get; }

    public PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
