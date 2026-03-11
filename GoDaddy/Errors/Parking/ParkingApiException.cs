using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Parking;

public class ParkingApiException : ApiException
{
    public ParkingApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public ParkingApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class ParkingBadRequestException : ParkingApiException { public ParkingBadRequestException(ApiException ex) : base(ex) { } }
public sealed class ParkingUnauthorizedException : ParkingApiException { public ParkingUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class ParkingForbiddenException : ParkingApiException { public ParkingForbiddenException(ApiException ex) : base(ex) { } }
public sealed class ParkingNotFoundException : ParkingApiException { public ParkingNotFoundException(ApiException ex) : base(ex) { } }
public sealed class ParkingConflictException : ParkingApiException { public ParkingConflictException(ApiException ex) : base(ex) { } }
public sealed class ParkingUnprocessableEntityException : ParkingApiException { public ParkingUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class ParkingRateLimitException : ParkingApiException { public ParkingRateLimitException(ApiException ex) : base(ex) { } }
public sealed class ParkingGatewayTimeoutException : ParkingApiException { public ParkingGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class ParkingServerException : ParkingApiException { public ParkingServerException(ApiException ex) : base(ex) { } }
