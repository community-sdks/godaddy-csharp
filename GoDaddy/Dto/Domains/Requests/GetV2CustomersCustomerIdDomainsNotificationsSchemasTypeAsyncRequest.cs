using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Type { get; }

    public GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Type
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Type = Type;
    }
}
