
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsPostAsyncRequest
{
    public string CustomerId { get; }
    public string Fqdn { get; }
    public DomainsForwardsPostAsyncRequestBody Body { get; }

    public DomainsForwardsPostAsyncRequest(
        string CustomerId,
        string Fqdn,
        DomainsForwardsPostAsyncRequestBody Body
    )
    {
        this.CustomerId = CustomerId;
        this.Fqdn = Fqdn;
        this.Body = Body;
    }
}
