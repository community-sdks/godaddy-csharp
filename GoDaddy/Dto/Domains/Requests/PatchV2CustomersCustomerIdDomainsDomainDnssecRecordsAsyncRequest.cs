
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body { get; }

    public PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
