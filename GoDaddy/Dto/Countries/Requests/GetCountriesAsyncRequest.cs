using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Countries.Requests;

public sealed class GetCountriesAsyncRequest
{
    public string MarketId { get; }

    public GetCountriesAsyncRequest(
        string MarketId
    )
    {
        this.MarketId = MarketId;
    }
}
