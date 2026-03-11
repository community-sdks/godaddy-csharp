using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Aftermarket;

public class AftermarketApiException : ApiException
{
    public AftermarketApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public AftermarketApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class AftermarketBadRequestException : AftermarketApiException { public AftermarketBadRequestException(ApiException ex) : base(ex) { } }
public sealed class AftermarketUnauthorizedException : AftermarketApiException { public AftermarketUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class AftermarketForbiddenException : AftermarketApiException { public AftermarketForbiddenException(ApiException ex) : base(ex) { } }
public sealed class AftermarketNotFoundException : AftermarketApiException { public AftermarketNotFoundException(ApiException ex) : base(ex) { } }
public sealed class AftermarketConflictException : AftermarketApiException { public AftermarketConflictException(ApiException ex) : base(ex) { } }
public sealed class AftermarketUnprocessableEntityException : AftermarketApiException { public AftermarketUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class AftermarketRateLimitException : AftermarketApiException { public AftermarketRateLimitException(ApiException ex) : base(ex) { } }
public sealed class AftermarketGatewayTimeoutException : AftermarketApiException { public AftermarketGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class AftermarketServerException : AftermarketApiException { public AftermarketServerException(ApiException ex) : base(ex) { } }
