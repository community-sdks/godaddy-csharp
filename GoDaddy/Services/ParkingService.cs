using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class ParkingService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public ParkingService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> GetMetricsAsync(object CustomerId, object? PeriodStartPtz, object? PeriodEndPtz, object? Limit, object? Offset, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/customers/{customerId}/parking/metrics",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("periodStartPtz", PeriodStartPtz),
            new KeyValuePair<string, object?>("periodEndPtz", PeriodEndPtz),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetMetricsByDomainAsync(object CustomerId, object StartDate, object EndDate, object? Domains, object? DomainLike, object? PortfolioId, object? Limit, object? Offset, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/customers/{customerId}/parking/metricsByDomain",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("startDate", StartDate),
            new KeyValuePair<string, object?>("endDate", EndDate),
            new KeyValuePair<string, object?>("domains", Domains),
            new KeyValuePair<string, object?>("domainLike", DomainLike),
            new KeyValuePair<string, object?>("portfolioId", PortfolioId),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }
}
