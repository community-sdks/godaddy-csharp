using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Agreements.Requests;

public sealed class GetAsyncRequest
{
    public int? XPrivateLabelId { get; }
    public string? XMarketId { get; }
    public IReadOnlyList<string> Keys { get; }

    public GetAsyncRequest(
        int? XPrivateLabelId,
        string? XMarketId,
        IReadOnlyList<string> Keys
    )
    {
        this.XPrivateLabelId = XPrivateLabelId;
        this.XMarketId = XMarketId;
        this.Keys = Keys;
    }
}
