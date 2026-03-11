namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody
{
    public IReadOnlyList<string>? NameServers { get; }

    public PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody(
        IReadOnlyList<string>? NameServers
    )
    {
        this.NameServers = NameServers;
    }
}
