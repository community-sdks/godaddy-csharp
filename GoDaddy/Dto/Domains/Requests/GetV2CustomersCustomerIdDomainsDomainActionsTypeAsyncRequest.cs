using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public string Type { get; }

    public GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        string Type
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Type = Type;
    }
}
