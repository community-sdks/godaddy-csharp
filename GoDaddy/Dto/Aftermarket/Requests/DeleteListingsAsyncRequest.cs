using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Requests;

public sealed class DeleteListingsAsyncRequest
{
    public IReadOnlyList<string> Domains { get; }

    public DeleteListingsAsyncRequest(
        IReadOnlyList<string> Domains
    )
    {
        this.Domains = Domains;
    }
}
