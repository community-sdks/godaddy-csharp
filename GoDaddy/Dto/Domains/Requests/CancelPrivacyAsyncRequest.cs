using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class CancelPrivacyAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }

    public CancelPrivacyAsyncRequest(
        string? XShopperId,
        string Domain
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
    }
}
