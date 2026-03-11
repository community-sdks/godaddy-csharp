using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class GetAgentCsrStatusByAgentIdAsyncRequest
{
    public string AgentId { get; }
    public string CsrId { get; }

    public GetAgentCsrStatusByAgentIdAsyncRequest(
        string AgentId,
        string CsrId
    )
    {
        this.AgentId = AgentId;
        this.CsrId = CsrId;
    }
}
