using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Auctions;

public class AuctionsApiException : ApiException
{
    public AuctionsApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public AuctionsApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class AuctionsBadRequestException : AuctionsApiException { public AuctionsBadRequestException(ApiException ex) : base(ex) { } }
public sealed class AuctionsUnauthorizedException : AuctionsApiException { public AuctionsUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class AuctionsForbiddenException : AuctionsApiException { public AuctionsForbiddenException(ApiException ex) : base(ex) { } }
public sealed class AuctionsNotFoundException : AuctionsApiException { public AuctionsNotFoundException(ApiException ex) : base(ex) { } }
public sealed class AuctionsConflictException : AuctionsApiException { public AuctionsConflictException(ApiException ex) : base(ex) { } }
public sealed class AuctionsUnprocessableEntityException : AuctionsApiException { public AuctionsUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class AuctionsRateLimitException : AuctionsApiException { public AuctionsRateLimitException(ApiException ex) : base(ex) { } }
public sealed class AuctionsGatewayTimeoutException : AuctionsApiException { public AuctionsGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class AuctionsServerException : AuctionsApiException { public AuctionsServerException(ApiException ex) : base(ex) { } }
