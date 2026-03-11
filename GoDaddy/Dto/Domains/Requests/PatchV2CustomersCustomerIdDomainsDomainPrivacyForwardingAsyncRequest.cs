
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody Body { get; }

    public PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
