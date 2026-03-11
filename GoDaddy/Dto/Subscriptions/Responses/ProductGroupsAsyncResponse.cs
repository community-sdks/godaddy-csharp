using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Responses;

public sealed class ProductGroupsAsyncResponse
{
    public JsonNode? Raw { get; }

    public ProductGroupsAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static ProductGroupsAsyncResponse FromJson(JsonNode? raw)
    {
        return new ProductGroupsAsyncResponse(raw);
    }
}
