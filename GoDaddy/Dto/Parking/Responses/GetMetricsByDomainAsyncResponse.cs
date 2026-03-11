using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Parking.Responses;

public sealed class GetMetricsByDomainAsyncResponse
{
    public JsonNode? Raw { get; }

    public GetMetricsByDomainAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static GetMetricsByDomainAsyncResponse FromJson(JsonNode? raw)
    {
        return new GetMetricsByDomainAsyncResponse(raw);
    }
}
