using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Domains;

public class DomainsApiException : ApiException
{
    public DomainsApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public DomainsApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class DomainsBadRequestException : DomainsApiException { public DomainsBadRequestException(ApiException ex) : base(ex) { } }
public sealed class DomainsUnauthorizedException : DomainsApiException { public DomainsUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class DomainsForbiddenException : DomainsApiException { public DomainsForbiddenException(ApiException ex) : base(ex) { } }
public sealed class DomainsNotFoundException : DomainsApiException { public DomainsNotFoundException(ApiException ex) : base(ex) { } }
public sealed class DomainsConflictException : DomainsApiException { public DomainsConflictException(ApiException ex) : base(ex) { } }
public sealed class DomainsUnprocessableEntityException : DomainsApiException { public DomainsUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class DomainsRateLimitException : DomainsApiException { public DomainsRateLimitException(ApiException ex) : base(ex) { } }
public sealed class DomainsGatewayTimeoutException : DomainsApiException { public DomainsGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class DomainsServerException : DomainsApiException { public DomainsServerException(ApiException ex) : base(ex) { } }
