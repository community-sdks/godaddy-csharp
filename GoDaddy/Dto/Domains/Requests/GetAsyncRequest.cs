using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }

    public GetAsyncRequest(
        string? XShopperId,
        string Domain
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
    }
}
