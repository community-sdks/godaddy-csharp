using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class ValidateRegistrationAsyncRequest
{
    public string AgentId { get; }

    public ValidateRegistrationAsyncRequest(
        string AgentId
    )
    {
        this.AgentId = AgentId;
    }
}
