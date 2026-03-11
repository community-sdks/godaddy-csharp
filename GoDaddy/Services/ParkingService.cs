using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Dto.Parking.Requests;
using CommunitySdks.GoDaddy.Dto.Parking.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Parking;

namespace CommunitySdks.GoDaddy.Services;

public sealed class ParkingService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public ParkingService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<GetMetricsAsyncResponse> GetMetricsAsync(GetMetricsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/customers/{customerId}/parking/metrics",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("periodStartPtz", request.PeriodStartPtz),
                new KeyValuePair<string, object?>("periodEndPtz", request.PeriodEndPtz),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetMetricsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetMetricsAsyncResponse> GetMetricsAsync(string CustomerId, string? PeriodStartPtz, string? PeriodEndPtz, int? Limit, int? Offset, string? XRequestId, CancellationToken cancellationToken = default)
    {
        return GetMetricsAsync(new GetMetricsAsyncRequest(CustomerId: CustomerId, PeriodStartPtz: PeriodStartPtz, PeriodEndPtz: PeriodEndPtz, Limit: Limit, Offset: Offset, XRequestId: XRequestId), cancellationToken);
    }

    public async Task<GetMetricsByDomainAsyncResponse> GetMetricsByDomainAsync(GetMetricsByDomainAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/customers/{customerId}/parking/metricsByDomain",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("startDate", request.StartDate),
                new KeyValuePair<string, object?>("endDate", request.EndDate),
                new KeyValuePair<string, object?>("domains", request.Domains),
                new KeyValuePair<string, object?>("domainLike", request.DomainLike),
                new KeyValuePair<string, object?>("portfolioId", request.PortfolioId),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetMetricsByDomainAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetMetricsByDomainAsyncResponse> GetMetricsByDomainAsync(string CustomerId, string StartDate, string EndDate, string? Domains, string? DomainLike, string? PortfolioId, int? Limit, int? Offset, string? XRequestId, CancellationToken cancellationToken = default)
    {
        return GetMetricsByDomainAsync(new GetMetricsByDomainAsyncRequest(CustomerId: CustomerId, StartDate: StartDate, EndDate: EndDate, Domains: Domains, DomainLike: DomainLike, PortfolioId: PortfolioId, Limit: Limit, Offset: Offset, XRequestId: XRequestId), cancellationToken);
    }

    private ParkingApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new ParkingBadRequestException(exception),
            401 => new ParkingUnauthorizedException(exception),
            403 => new ParkingForbiddenException(exception),
            404 => new ParkingNotFoundException(exception),
            409 => new ParkingConflictException(exception),
            422 => new ParkingUnprocessableEntityException(exception),
            429 => new ParkingRateLimitException(exception),
            504 => new ParkingGatewayTimeoutException(exception),
            _ => new ParkingServerException(exception),
        };
    }
}
