using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Orders;

public class OrdersApiException : ApiException
{
    public OrdersApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public OrdersApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class OrdersBadRequestException : OrdersApiException { public OrdersBadRequestException(ApiException ex) : base(ex) { } }
public sealed class OrdersUnauthorizedException : OrdersApiException { public OrdersUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class OrdersForbiddenException : OrdersApiException { public OrdersForbiddenException(ApiException ex) : base(ex) { } }
public sealed class OrdersNotFoundException : OrdersApiException { public OrdersNotFoundException(ApiException ex) : base(ex) { } }
public sealed class OrdersConflictException : OrdersApiException { public OrdersConflictException(ApiException ex) : base(ex) { } }
public sealed class OrdersUnprocessableEntityException : OrdersApiException { public OrdersUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class OrdersRateLimitException : OrdersApiException { public OrdersRateLimitException(ApiException ex) : base(ex) { } }
public sealed class OrdersGatewayTimeoutException : OrdersApiException { public OrdersGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class OrdersServerException : OrdersApiException { public OrdersServerException(ApiException ex) : base(ex) { } }
