using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class SearchANSNameAsyncResponse
{
    public JsonNode? Raw { get; }

    public SearchANSNameAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static SearchANSNameAsyncResponse FromJson(JsonNode? raw)
    {
        return new SearchANSNameAsyncResponse(raw);
    }
}
