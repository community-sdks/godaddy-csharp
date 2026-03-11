using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsDomainAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public IReadOnlyList<string>? Includes { get; }

    public GetV2CustomersCustomerIdDomainsDomainAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        IReadOnlyList<string>? Includes
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Includes = Includes;
    }
}
