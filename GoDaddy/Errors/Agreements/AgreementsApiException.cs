using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Agreements;

public class AgreementsApiException : ApiException
{
    public AgreementsApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public AgreementsApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class AgreementsBadRequestException : AgreementsApiException { public AgreementsBadRequestException(ApiException ex) : base(ex) { } }
public sealed class AgreementsUnauthorizedException : AgreementsApiException { public AgreementsUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class AgreementsForbiddenException : AgreementsApiException { public AgreementsForbiddenException(ApiException ex) : base(ex) { } }
public sealed class AgreementsNotFoundException : AgreementsApiException { public AgreementsNotFoundException(ApiException ex) : base(ex) { } }
public sealed class AgreementsConflictException : AgreementsApiException { public AgreementsConflictException(ApiException ex) : base(ex) { } }
public sealed class AgreementsUnprocessableEntityException : AgreementsApiException { public AgreementsUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class AgreementsRateLimitException : AgreementsApiException { public AgreementsRateLimitException(ApiException ex) : base(ex) { } }
public sealed class AgreementsGatewayTimeoutException : AgreementsApiException { public AgreementsGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class AgreementsServerException : AgreementsApiException { public AgreementsServerException(ApiException ex) : base(ex) { } }
