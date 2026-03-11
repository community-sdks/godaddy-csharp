using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Responses;

public sealed class GetAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetAsyncResponse(raw);
    }
}
