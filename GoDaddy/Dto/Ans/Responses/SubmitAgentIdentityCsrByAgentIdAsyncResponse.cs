using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class SubmitAgentIdentityCsrByAgentIdAsyncResponse
{
    public JsonNode? Raw { get; }

    public SubmitAgentIdentityCsrByAgentIdAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static SubmitAgentIdentityCsrByAgentIdAsyncResponse FromJson(JsonNode? raw)
    {
        return new SubmitAgentIdentityCsrByAgentIdAsyncResponse(raw);
    }
}
