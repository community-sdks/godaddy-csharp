using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Countries.Responses;

public sealed class GetCountriesAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetCountriesAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetCountriesAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetCountriesAsyncResponse(raw);
    }
}
