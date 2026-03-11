using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Requests;

public sealed class GetListingsAsyncRequest
{
    public string CustomerId { get; }
    public string? Domains { get; }
    public string? ListingStatus { get; }
    public string? TransferBefore { get; }
    public string? TransferAfter { get; }
    public int? Limit { get; }
    public int? Offset { get; }

    public GetListingsAsyncRequest(
        string CustomerId,
        string? Domains,
        string? ListingStatus,
        string? TransferBefore,
        string? TransferAfter,
        int? Limit,
        int? Offset
    )
    {
        this.CustomerId = CustomerId;
        this.Domains = Domains;
        this.ListingStatus = ListingStatus;
        this.TransferBefore = TransferBefore;
        this.TransferAfter = TransferAfter;
        this.Limit = Limit;
        this.Offset = Offset;
    }
}
