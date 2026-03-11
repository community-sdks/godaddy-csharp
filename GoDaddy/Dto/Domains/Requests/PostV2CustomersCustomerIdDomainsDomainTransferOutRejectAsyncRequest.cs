using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public string? Reason { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        string? Reason
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Reason = Reason;
    }
}
