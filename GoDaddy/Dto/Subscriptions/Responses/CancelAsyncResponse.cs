using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Responses;

public sealed class CancelAsyncResponse
{
    public JsonNode? Raw { get; }

    public CancelAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static CancelAsyncResponse FromJson(JsonNode? raw)
    {
        return new CancelAsyncResponse(raw);
    }
}
