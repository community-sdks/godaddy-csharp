using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsGetAsyncRequest
{
    public string CustomerId { get; }
    public string Fqdn { get; }
    public bool? IncludeSubs { get; }

    public DomainsForwardsGetAsyncRequest(
        string CustomerId,
        string Fqdn,
        bool? IncludeSubs
    )
    {
        this.CustomerId = CustomerId;
        this.Fqdn = Fqdn;
        this.IncludeSubs = IncludeSubs;
    }
}
