using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }

    public GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(
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
