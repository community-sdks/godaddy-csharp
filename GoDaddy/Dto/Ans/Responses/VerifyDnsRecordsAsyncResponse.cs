using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class VerifyDnsRecordsAsyncResponse
{
    public JsonNode? Raw { get; }

    public VerifyDnsRecordsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static VerifyDnsRecordsAsyncResponse FromJson(JsonNode? raw)
    {
        return new VerifyDnsRecordsAsyncResponse(raw);
    }
}
