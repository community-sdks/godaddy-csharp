using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Auctions.Responses;

public sealed class PlaceBidsAsyncResponse
{
    public JsonNode? Raw { get; }

    public PlaceBidsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static PlaceBidsAsyncResponse FromJson(JsonNode? raw)
    {
        return new PlaceBidsAsyncResponse(raw);
    }
}
