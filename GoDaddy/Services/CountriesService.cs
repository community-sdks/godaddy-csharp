using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class CountriesService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public CountriesService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> GetCountriesAsync(object MarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/countries",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("marketId", MarketId),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetCountryAsync(object CountryKey, object MarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/countries/{countryKey}",
            new[]
        {
            new KeyValuePair<string, object?>("countryKey", CountryKey),
        },
            new[]
        {
            new KeyValuePair<string, object?>("marketId", MarketId),
        },
            null,
            null,
            cancellationToken);
    }
}
