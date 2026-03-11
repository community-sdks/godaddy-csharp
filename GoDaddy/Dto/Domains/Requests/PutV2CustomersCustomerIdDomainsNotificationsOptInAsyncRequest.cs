using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public IReadOnlyList<string> Types { get; }

    public PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest(
        string? XRequestId,
        string CustomerId,
        IReadOnlyList<string> Types
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Types = Types;
    }
}
