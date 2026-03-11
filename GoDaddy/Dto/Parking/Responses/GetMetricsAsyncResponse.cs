using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Parking.Responses;

public sealed class GetMetricsAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetMetricsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetMetricsAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetMetricsAsyncResponse(raw);
    }
}
