using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Responses;

public sealed class ChangePasswordAsyncResponse
{
    public JsonNode? Raw { get; }

    public ChangePasswordAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static ChangePasswordAsyncResponse FromJson(JsonNode? raw)
    {
        return new ChangePasswordAsyncResponse(raw);
    }
}
