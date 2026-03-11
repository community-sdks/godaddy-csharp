using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string Domain { get; }
    public string Registrar { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string Domain,
        string Registrar
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.Domain = Domain;
        this.Registrar = Registrar;
    }
}
