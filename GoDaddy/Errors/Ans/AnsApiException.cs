using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Ans;

public class AnsApiException : ApiException
{
    public AnsApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public AnsApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class AnsBadRequestException : AnsApiException { public AnsBadRequestException(ApiException ex) : base(ex) { } }
public sealed class AnsUnauthorizedException : AnsApiException { public AnsUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class AnsForbiddenException : AnsApiException { public AnsForbiddenException(ApiException ex) : base(ex) { } }
public sealed class AnsNotFoundException : AnsApiException { public AnsNotFoundException(ApiException ex) : base(ex) { } }
public sealed class AnsConflictException : AnsApiException { public AnsConflictException(ApiException ex) : base(ex) { } }
public sealed class AnsUnprocessableEntityException : AnsApiException { public AnsUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class AnsRateLimitException : AnsApiException { public AnsRateLimitException(ApiException ex) : base(ex) { } }
public sealed class AnsGatewayTimeoutException : AnsApiException { public AnsGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class AnsServerException : AnsApiException { public AnsServerException(ApiException ex) : base(ex) { } }
