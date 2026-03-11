using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class GetAgentIdentityCertificateByAgentIdAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAgentIdentityCertificateByAgentIdAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAgentIdentityCertificateByAgentIdAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAgentIdentityCertificateByAgentIdAsyncResponse(raw);
    }
}
