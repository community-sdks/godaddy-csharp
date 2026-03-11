using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class VerifyEmailAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }

    public VerifyEmailAsyncRequest(
        string? XShopperId,
        string Domain
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
    }
}
