using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class GetAgentEventsAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAgentEventsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAgentEventsAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAgentEventsAsyncResponse(raw);
    }
}
