using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Responses;

public sealed class DeleteListingsAsyncResponse
{
    public JsonNode? Raw { get; }

    public DeleteListingsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static DeleteListingsAsyncResponse FromJson(JsonNode? raw)
    {
        return new DeleteListingsAsyncResponse(raw);
    }
}
