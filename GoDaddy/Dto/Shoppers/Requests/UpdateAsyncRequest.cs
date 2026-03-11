
namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class UpdateAsyncRequest
{
    public string ShopperId { get; }
    public UpdateAsyncRequestShopper Shopper { get; }

    public UpdateAsyncRequest(
        string ShopperId,
        UpdateAsyncRequestShopper Shopper
    )
    {
        this.ShopperId = ShopperId;
        this.Shopper = Shopper;
    }
}
