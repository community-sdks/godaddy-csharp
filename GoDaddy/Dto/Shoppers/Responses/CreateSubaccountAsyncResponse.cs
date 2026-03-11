using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Responses;

public sealed class CreateSubaccountAsyncResponse
{
    public JsonNode? Raw { get; }

    public CreateSubaccountAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static CreateSubaccountAsyncResponse FromJson(JsonNode? raw)
    {
        return new CreateSubaccountAsyncResponse(raw);
    }
}
