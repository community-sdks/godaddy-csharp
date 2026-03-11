using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Responses;

public sealed class ValidateRegistrationAsyncResponse
{
    public JsonNode? Raw { get; }

    public ValidateRegistrationAsyncResponse(JsonNode? raw)
    {
        Raw = raw;
    }

    public static ValidateRegistrationAsyncResponse FromJson(JsonNode? raw)
    {
        return new ValidateRegistrationAsyncResponse(raw);
    }
}
