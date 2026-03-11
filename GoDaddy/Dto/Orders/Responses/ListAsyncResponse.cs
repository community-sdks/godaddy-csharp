using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Orders.Responses;

public sealed class ListAsyncResponse
{
    public JsonNode? Raw { get; }

    public ListAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static ListAsyncResponse FromJson(JsonNode? raw)
    {
        return new ListAsyncResponse(raw);
    }
}
