using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Responses;

public sealed class AddExpiryListingsAsyncResponse
{
    public JsonNode? Raw { get; }

    public AddExpiryListingsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static AddExpiryListingsAsyncResponse FromJson(JsonNode? raw)
    {
        return new AddExpiryListingsAsyncResponse(raw);
    }
}
