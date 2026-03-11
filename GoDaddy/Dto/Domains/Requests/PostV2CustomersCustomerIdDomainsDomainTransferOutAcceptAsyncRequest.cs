using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncRequest(
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
