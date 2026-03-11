using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class CancelAsyncRequest
{
    public string Domain { get; }

    public CancelAsyncRequest(
        string Domain
    )
    {
        this.Domain = Domain;
    }
}
