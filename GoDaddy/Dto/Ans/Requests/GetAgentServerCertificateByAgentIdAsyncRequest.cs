using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class GetAgentServerCertificateByAgentIdAsyncRequest
{
    public string AgentId { get; }

    public GetAgentServerCertificateByAgentIdAsyncRequest(
        string AgentId
    )
    {
        this.AgentId = AgentId;
    }
}
