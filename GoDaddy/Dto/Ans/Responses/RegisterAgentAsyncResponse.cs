using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class RegisterAgentAsyncResponse
{
    public JsonNode? Raw { get; }

    public RegisterAgentAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static RegisterAgentAsyncResponse FromJson(JsonNode? raw)
    {
        return new RegisterAgentAsyncResponse(raw);
    }
}
