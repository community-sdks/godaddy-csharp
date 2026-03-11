
namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class RevokeAgentAsyncRequest
{
    public string AgentId { get; }
    public RevokeAgentAsyncRequestBody Body { get; }

    public RevokeAgentAsyncRequest(
        string AgentId,
        RevokeAgentAsyncRequestBody Body
    )
    {
        this.AgentId = AgentId;
        this.Body = Body;
    }
}
