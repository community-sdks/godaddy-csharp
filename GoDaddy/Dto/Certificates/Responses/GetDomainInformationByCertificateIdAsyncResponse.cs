using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Responses;

public sealed class GetDomainInformationByCertificateIdAsyncResponse
{
    public JsonNode? Raw { get; }
    public JsonObject? Object { get; }
    public JsonArray? Items { get; }
    public string? Code { get; }
    public string? Message { get; }

    public GetDomainInformationByCertificateIdAsyncResponse(JsonNode? raw, JsonObject? @object, JsonArray? items, string? code, string? message)
    {
        Raw = raw;
        Object = @object;
        Items = items;
        Code = code;
        Message = message;
    }

    public static GetDomainInformationByCertificateIdAsyncResponse FromJson(JsonNode? raw)
    {
        var @object = raw as JsonObject;
        var items = raw as JsonArray;
        var code = @object?["code"]?.GetValue<string>();
        var message = @object?["message"]?.GetValue<string>();

        return new GetDomainInformationByCertificateIdAsyncResponse(raw, @object, items, code, message);
    }
}
