using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Abuse;

public class AbuseApiException : ApiException
{
    public AbuseApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public AbuseApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class AbuseBadRequestException : AbuseApiException { public AbuseBadRequestException(ApiException ex) : base(ex) { } }
public sealed class AbuseUnauthorizedException : AbuseApiException { public AbuseUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class AbuseForbiddenException : AbuseApiException { public AbuseForbiddenException(ApiException ex) : base(ex) { } }
public sealed class AbuseNotFoundException : AbuseApiException { public AbuseNotFoundException(ApiException ex) : base(ex) { } }
public sealed class AbuseConflictException : AbuseApiException { public AbuseConflictException(ApiException ex) : base(ex) { } }
public sealed class AbuseUnprocessableEntityException : AbuseApiException { public AbuseUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class AbuseRateLimitException : AbuseApiException { public AbuseRateLimitException(ApiException ex) : base(ex) { } }
public sealed class AbuseGatewayTimeoutException : AbuseApiException { public AbuseGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class AbuseServerException : AbuseApiException { public AbuseServerException(ApiException ex) : base(ex) { } }
