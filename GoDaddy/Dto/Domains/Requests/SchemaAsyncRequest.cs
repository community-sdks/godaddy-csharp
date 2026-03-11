using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class SchemaAsyncRequest
{
    public string Tld { get; }

    public SchemaAsyncRequest(
        string Tld
    )
    {
        this.Tld = Tld;
    }
}
