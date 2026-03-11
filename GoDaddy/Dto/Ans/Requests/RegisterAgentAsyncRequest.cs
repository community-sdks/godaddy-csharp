
namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class RegisterAgentAsyncRequest
{
    public RegisterAgentAsyncRequestBody Body { get; }

    public RegisterAgentAsyncRequest(
        RegisterAgentAsyncRequestBody Body
    )
    {
        this.Body = Body;
    }
}
