using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class RevokeAgentAsyncResponse
{
    public JsonNode? Raw { get; }

    public RevokeAgentAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static RevokeAgentAsyncResponse FromJson(JsonNode? raw)
    {
        return new RevokeAgentAsyncResponse(raw);
    }
}
