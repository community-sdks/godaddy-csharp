
namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class SubmitAgentIdentityCsrByAgentIdAsyncRequest
{
    public string AgentId { get; }
    public SubmitAgentIdentityCsrByAgentIdAsyncRequestBody Body { get; }

    public SubmitAgentIdentityCsrByAgentIdAsyncRequest(
        string AgentId,
        SubmitAgentIdentityCsrByAgentIdAsyncRequestBody Body
    )
    {
        this.AgentId = AgentId;
        this.Body = Body;
    }
}
