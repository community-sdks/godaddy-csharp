
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsPutAsyncRequest
{
    public string CustomerId { get; }
    public string Fqdn { get; }
    public DomainsForwardsPutAsyncRequestBody Body { get; }

    public DomainsForwardsPutAsyncRequest(
        string CustomerId,
        string Fqdn,
        DomainsForwardsPutAsyncRequestBody Body
    )
    {
        this.CustomerId = CustomerId;
        this.Fqdn = Fqdn;
        this.Body = Body;
    }
}
