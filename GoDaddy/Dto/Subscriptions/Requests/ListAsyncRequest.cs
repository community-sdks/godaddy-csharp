using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class ListAsyncRequest
{
    public string XAppKey { get; }
    public string? XShopperId { get; }
    public string? XMarketId { get; }
    public IReadOnlyList<string>? ProductGroupKeys { get; }
    public IReadOnlyList<string>? Includes { get; }
    public int? Offset { get; }
    public int? Limit { get; }
    public string? Sort { get; }

    public ListAsyncRequest(
        string XAppKey,
        string? XShopperId,
        string? XMarketId,
        IReadOnlyList<string>? ProductGroupKeys,
        IReadOnlyList<string>? Includes,
        int? Offset,
        int? Limit,
        string? Sort
    )
    {
        this.XAppKey = XAppKey;
        this.XShopperId = XShopperId;
        this.XMarketId = XMarketId;
        this.ProductGroupKeys = ProductGroupKeys;
        this.Includes = Includes;
        this.Offset = Offset;
        this.Limit = Limit;
        this.Sort = Sort;
    }
}
