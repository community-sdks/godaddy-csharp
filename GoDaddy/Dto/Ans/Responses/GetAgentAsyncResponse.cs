using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class GetAgentAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAgentAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAgentAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAgentAsyncResponse(raw);
    }
}
