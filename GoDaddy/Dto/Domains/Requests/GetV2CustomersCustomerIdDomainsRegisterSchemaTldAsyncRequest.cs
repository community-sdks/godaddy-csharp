using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Tld { get; }

    public GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Tld
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Tld = Tld;
    }
}
