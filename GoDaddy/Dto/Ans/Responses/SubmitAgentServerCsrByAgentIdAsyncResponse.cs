using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class SubmitAgentServerCsrByAgentIdAsyncResponse
{
    public JsonNode? Raw { get; }

    public SubmitAgentServerCsrByAgentIdAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static SubmitAgentServerCsrByAgentIdAsyncResponse FromJson(JsonNode? raw)
    {
        return new SubmitAgentServerCsrByAgentIdAsyncResponse(raw);
    }
}
