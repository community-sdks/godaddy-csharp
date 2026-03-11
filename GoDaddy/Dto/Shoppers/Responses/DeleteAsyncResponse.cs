using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Responses;

public sealed class DeleteAsyncResponse
{
    public JsonNode? Raw { get; }

    public DeleteAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static DeleteAsyncResponse FromJson(JsonNode? raw)
    {
        return new DeleteAsyncResponse(raw);
    }
}
