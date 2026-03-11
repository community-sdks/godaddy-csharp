using CommunitySdks.GoDaddy.Errors;

namespace CommunitySdks.GoDaddy.Errors.Certificates;

public class CertificatesApiException : ApiException
{
    public CertificatesApiException(string message, int statusCode, string responseBody, IReadOnlyDictionary<string, string> headers, string requestMethod, string requestUrl)
        : base(message, statusCode, responseBody, headers, requestMethod, requestUrl)
    {
    }

    public CertificatesApiException(ApiException exception)
        : base(exception.Message, exception.StatusCode, exception.ResponseBody, exception.Headers, exception.RequestMethod, exception.RequestUrl)
    {
    }
}

public sealed class CertificatesBadRequestException : CertificatesApiException { public CertificatesBadRequestException(ApiException ex) : base(ex) { } }
public sealed class CertificatesUnauthorizedException : CertificatesApiException { public CertificatesUnauthorizedException(ApiException ex) : base(ex) { } }
public sealed class CertificatesForbiddenException : CertificatesApiException { public CertificatesForbiddenException(ApiException ex) : base(ex) { } }
public sealed class CertificatesNotFoundException : CertificatesApiException { public CertificatesNotFoundException(ApiException ex) : base(ex) { } }
public sealed class CertificatesConflictException : CertificatesApiException { public CertificatesConflictException(ApiException ex) : base(ex) { } }
public sealed class CertificatesUnprocessableEntityException : CertificatesApiException { public CertificatesUnprocessableEntityException(ApiException ex) : base(ex) { } }
public sealed class CertificatesRateLimitException : CertificatesApiException { public CertificatesRateLimitException(ApiException ex) : base(ex) { } }
public sealed class CertificatesGatewayTimeoutException : CertificatesApiException { public CertificatesGatewayTimeoutException(ApiException ex) : base(ex) { } }
public sealed class CertificatesServerException : CertificatesApiException { public CertificatesServerException(ApiException ex) : base(ex) { } }
