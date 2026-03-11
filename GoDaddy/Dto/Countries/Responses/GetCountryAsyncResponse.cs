using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Countries.Responses;

public sealed class GetCountryAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetCountryAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetCountryAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetCountryAsyncResponse(raw);
    }
}
