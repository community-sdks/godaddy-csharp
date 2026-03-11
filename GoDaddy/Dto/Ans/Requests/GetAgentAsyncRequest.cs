using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class GetAgentAsyncRequest
{
    public string AgentId { get; }

    public GetAgentAsyncRequest(
        string AgentId
    )
    {
        this.AgentId = AgentId;
    }
}
