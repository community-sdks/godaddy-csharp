using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Responses;

public sealed class UpdateAsyncResponse
{
    public JsonNode? Raw { get; }

    public UpdateAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static UpdateAsyncResponse FromJson(JsonNode? raw)
    {
        return new UpdateAsyncResponse(raw);
    }
}
