namespace CommunitySdks.GoDaddy.Http;

public sealed class HttpResponse
{
    public required int StatusCode { get; init; }
    public required IReadOnlyDictionary<string, string> Headers { get; init; }
    public required string Body { get; init; }
}
