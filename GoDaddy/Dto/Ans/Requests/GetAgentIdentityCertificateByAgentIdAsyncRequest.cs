using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class GetAgentIdentityCertificateByAgentIdAsyncRequest
{
    public string AgentId { get; }

    public GetAgentIdentityCertificateByAgentIdAsyncRequest(
        string AgentId
    )
    {
        this.AgentId = AgentId;
    }
}
