using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Responses;

public sealed class GetListingsAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetListingsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetListingsAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetListingsAsyncResponse(raw);
    }
}
