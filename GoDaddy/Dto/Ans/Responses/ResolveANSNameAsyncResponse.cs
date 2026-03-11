using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class ResolveANSNameAsyncResponse
{
    public JsonNode? Raw { get; }

    public ResolveANSNameAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static ResolveANSNameAsyncResponse FromJson(JsonNode? raw)
    {
        return new ResolveANSNameAsyncResponse(raw);
    }
}
