using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Subscriptions;

public class SubscriptionsApiException : ApiException
{
    public SubscriptionsApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public SubscriptionsApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class SubscriptionsBadRequestException : SubscriptionsApiException { public SubscriptionsBadRequestException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsUnauthorizedException : SubscriptionsApiException { public SubscriptionsUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsForbiddenException : SubscriptionsApiException { public SubscriptionsForbiddenException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsNotFoundException : SubscriptionsApiException { public SubscriptionsNotFoundException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsConflictException : SubscriptionsApiException { public SubscriptionsConflictException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsUnprocessableEntityException : SubscriptionsApiException { public SubscriptionsUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsRateLimitException : SubscriptionsApiException { public SubscriptionsRateLimitException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsGatewayTimeoutException : SubscriptionsApiException { public SubscriptionsGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class SubscriptionsServerException : SubscriptionsApiException { public SubscriptionsServerException(ApiException ex) : base(ex) { } }
