using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Dto.Countries.Requests;
using CommunitySdks.GoDaddy.Dto.Countries.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Countries;

namespace CommunitySdks.GoDaddy.Services;

public sealed class CountriesService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public CountriesService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<GetCountriesAsyncResponse> GetCountriesAsync(GetCountriesAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/countries",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("marketId", request.MarketId),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetCountriesAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetCountriesAsyncResponse> GetCountriesAsync(string MarketId, CancellationToken cancellationToken = default)
    {
        return GetCountriesAsync(new GetCountriesAsyncRequest(MarketId: MarketId), cancellationToken);
    }

    public async Task<GetCountryAsyncResponse> GetCountryAsync(GetCountryAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/countries/{countryKey}",
                new[]
            {
                new KeyValuePair<string, object?>("countryKey", request.CountryKey),
            },
                new[]
            {
                new KeyValuePair<string, object?>("marketId", request.MarketId),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetCountryAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetCountryAsyncResponse> GetCountryAsync(string CountryKey, string MarketId, CancellationToken cancellationToken = default)
    {
        return GetCountryAsync(new GetCountryAsyncRequest(CountryKey: CountryKey, MarketId: MarketId), cancellationToken);
    }

    private CountriesApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new CountriesBadRequestException(exception),
            401 => new CountriesUnauthorizedException(exception),
            403 => new CountriesForbiddenException(exception),
            404 => new CountriesNotFoundException(exception),
            409 => new CountriesConflictException(exception),
            422 => new CountriesUnprocessableEntityException(exception),
            429 => new CountriesRateLimitException(exception),
            504 => new CountriesGatewayTimeoutException(exception),
            _ => new CountriesServerException(exception),
        };
    }
}
