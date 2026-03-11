using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2CustomersCustomerIdDomainsNotificationsAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }

    public GetV2CustomersCustomerIdDomainsNotificationsAsyncRequest(
        string? XRequestId,
        string CustomerId
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
    }
}
