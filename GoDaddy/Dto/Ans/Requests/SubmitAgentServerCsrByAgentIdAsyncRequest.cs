
namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class SubmitAgentServerCsrByAgentIdAsyncRequest
{
    public string AgentId { get; }
    public SubmitAgentServerCsrByAgentIdAsyncRequestBody Body { get; }

    public SubmitAgentServerCsrByAgentIdAsyncRequest(
        string AgentId,
        SubmitAgentServerCsrByAgentIdAsyncRequestBody Body
    )
    {
        this.AgentId = AgentId;
        this.Body = Body;
    }
}
