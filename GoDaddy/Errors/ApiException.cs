using System.Collections.ObjectModel;

namespace CommunitySdks.GoDaddy.Errors;

public class ApiException : Exception
{
    public int StatusCode { get; }
    public string ResponseBody { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }
    public string RequestMethod { get; }
    public string RequestUrl { get; }

    public ApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message)
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
        Headers = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(headers));
        RequestMethod = requestMethod;
        RequestUrl = requestUrl;
    }

    public string? GetRequestId()
    {
        if (Headers.TryGetValue("x-request-id", out var lower)) return lower;
        if (Headers.TryGetValue("X-Request-Id", out var upper)) return upper;
        return null;
    }
}

public sealed class ValidationException : ApiException { public ValidationException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message, statusCode, responseBody, headers, requestMethod, requestUrl) { } }
public sealed class UnauthorizedException : ApiException { public UnauthorizedException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message, statusCode, responseBody, headers, requestMethod, requestUrl) { } }
public sealed class NotFoundException : ApiException { public NotFoundException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message, statusCode, responseBody, headers, requestMethod, requestUrl) { } }
public sealed class RateLimitException : ApiException { public RateLimitException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message, statusCode, responseBody, headers, requestMethod, requestUrl) { } }
public sealed class ServerException : ApiException { public ServerException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl) : base(message, statusCode, responseBody, headers, requestMethod, requestUrl) { } }
