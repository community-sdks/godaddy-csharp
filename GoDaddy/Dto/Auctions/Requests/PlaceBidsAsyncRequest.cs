
namespace CommunitySdks.GoDaddy.Dto.Auctions.Requests;

public sealed class PlaceBidsAsyncRequest
{
    public string CustomerId { get; }
    public PlaceBidsAsyncRequestRequestBody RequestBody { get; }

    public PlaceBidsAsyncRequest(
        string CustomerId,
        PlaceBidsAsyncRequestRequestBody RequestBody
    )
    {
        this.CustomerId = CustomerId;
        this.RequestBody = RequestBody;
    }
}
