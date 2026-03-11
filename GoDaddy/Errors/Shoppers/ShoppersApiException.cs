using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Shoppers;

public class ShoppersApiException : ApiException
{
    public ShoppersApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public ShoppersApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class ShoppersBadRequestException : ShoppersApiException { public ShoppersBadRequestException(ApiException ex) : base(ex) { } }
public sealed class ShoppersUnauthorizedException : ShoppersApiException { public ShoppersUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class ShoppersForbiddenException : ShoppersApiException { public ShoppersForbiddenException(ApiException ex) : base(ex) { } }
public sealed class ShoppersNotFoundException : ShoppersApiException { public ShoppersNotFoundException(ApiException ex) : base(ex) { } }
public sealed class ShoppersConflictException : ShoppersApiException { public ShoppersConflictException(ApiException ex) : base(ex) { } }
public sealed class ShoppersUnprocessableEntityException : ShoppersApiException { public ShoppersUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class ShoppersRateLimitException : ShoppersApiException { public ShoppersRateLimitException(ApiException ex) : base(ex) { } }
public sealed class ShoppersGatewayTimeoutException : ShoppersApiException { public ShoppersGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class ShoppersServerException : ShoppersApiException { public ShoppersServerException(ApiException ex) : base(ex) { } }
