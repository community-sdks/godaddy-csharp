using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsDeleteAsyncRequest
{
    public string CustomerId { get; }
    public string Fqdn { get; }

    public DomainsForwardsDeleteAsyncRequest(
        string CustomerId,
        string Fqdn
    )
    {
        this.CustomerId = CustomerId;
        this.Fqdn = Fqdn;
    }
}
