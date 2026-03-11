using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class GetAgentCsrStatusByAgentIdAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAgentCsrStatusByAgentIdAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAgentCsrStatusByAgentIdAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAgentCsrStatusByAgentIdAsyncResponse(raw);
    }
}
