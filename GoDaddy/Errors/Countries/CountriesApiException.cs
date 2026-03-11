using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Countries;

public class CountriesApiException : ApiException
{
    public CountriesApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public CountriesApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class CountriesBadRequestException : CountriesApiException { public CountriesBadRequestException(ApiException ex) : base(ex) { } }
public sealed class CountriesUnauthorizedException : CountriesApiException { public CountriesUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class CountriesForbiddenException : CountriesApiException { public CountriesForbiddenException(ApiException ex) : base(ex) { } }
public sealed class CountriesNotFoundException : CountriesApiException { public CountriesNotFoundException(ApiException ex) : base(ex) { } }
public sealed class CountriesConflictException : CountriesApiException { public CountriesConflictException(ApiException ex) : base(ex) { } }
public sealed class CountriesUnprocessableEntityException : CountriesApiException { public CountriesUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class CountriesRateLimitException : CountriesApiException { public CountriesRateLimitException(ApiException ex) : base(ex) { } }
public sealed class CountriesGatewayTimeoutException : CountriesApiException { public CountriesGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class CountriesServerException : CountriesApiException { public CountriesServerException(ApiException ex) : base(ex) { } }
