using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsDomainTransferAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }

    public GetV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
    }
}
