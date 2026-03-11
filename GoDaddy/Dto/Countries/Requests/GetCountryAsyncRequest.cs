using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Countries.Requests;

public sealed class GetCountryAsyncRequest
{
    public string CountryKey { get; }
    public string MarketId { get; }

    public GetCountryAsyncRequest(
        string CountryKey,
        string MarketId
    )
    {
        this.CountryKey = CountryKey;
        this.MarketId = MarketId;
    }
}
