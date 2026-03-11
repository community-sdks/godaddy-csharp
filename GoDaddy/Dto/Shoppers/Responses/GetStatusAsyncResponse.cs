using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Responses;

public sealed class GetStatusAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetStatusAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetStatusAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetStatusAsyncResponse(raw);
    }
}
