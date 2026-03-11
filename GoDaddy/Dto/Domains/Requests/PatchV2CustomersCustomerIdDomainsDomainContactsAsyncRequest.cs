
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody Body { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
