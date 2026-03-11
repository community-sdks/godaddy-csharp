
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body { get; }

    public DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
