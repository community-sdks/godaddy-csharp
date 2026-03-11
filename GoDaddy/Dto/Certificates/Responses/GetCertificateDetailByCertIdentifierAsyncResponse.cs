using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Responses;

public sealed class GetCertificateDetailByCertIdentifierAsyncResponse
{
    public JsonNode? Raw { get; }
    public JsonObject? Object { get; }
    public JsonArray? Items { get; }
    public string? Code { get; }
    public string? Message { get; }

    public GetCertificateDetailByCertIdentifierAsyncResponse(JsonNode? raw, JsonObject? @object, JsonArray? items, string? code, string? message)
    {
        Raw = raw;
        Object = @object;
        Items = items;
        Code = code;
        Message = message;
    }

    public static GetCertificateDetailByCertIdentifierAsyncResponse FromJson(JsonNode? raw)
    {
        var @object = raw as JsonObject;
        var items = raw as JsonArray;
        var code = @object?["code"]?.GetValue<string>();
        var message = @object?["message"]?.GetValue<string>();

        return new GetCertificateDetailByCertIdentifierAsyncResponse(raw, @object, items, code, message);
    }
}
