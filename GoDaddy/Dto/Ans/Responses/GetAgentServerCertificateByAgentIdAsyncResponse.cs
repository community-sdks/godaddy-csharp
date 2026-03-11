using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class GetAgentServerCertificateByAgentIdAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAgentServerCertificateByAgentIdAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAgentServerCertificateByAgentIdAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAgentServerCertificateByAgentIdAsyncResponse(raw);
    }
}
