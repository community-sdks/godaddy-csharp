using System.Text;

namespace CommunitySdks.GoDaddy.Http;

public sealed class HttpRequest
{
    public required string Method { get; init; }
    public required string Url { get; init; }
    public required IReadOnlyDictionary<string, string> Headers { get; init; }
    public required IReadOnlyList<KeyValuePair<string, string>> Query { get; init; }
    public object? Body { get; init; }
    public TimeSpan Timeout { get; init; }

    public string FullUrl()
    {
        if (Query.Count == 0) return Url;
        var builder = new StringBuilder();
        builder.Append(Url);
        builder.Append('?');
        for (var i = 0; i < Query.Count; i++)
        {
            if (i > 0) builder.Append('&');
            builder.Append(Uri.EscapeDataString(Query[i].Key));
            builder.Append('=');
            builder.Append(Uri.EscapeDataString(Query[i].Value));
        }
        return builder.ToString();
    }
}
