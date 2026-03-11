
namespace CommunitySdks.GoDaddy.Dto.Aftermarket.Requests;

public sealed class AddExpiryListingsAsyncRequest
{
    public AddExpiryListingsAsyncRequestExpiryListings ExpiryListings { get; }

    public AddExpiryListingsAsyncRequest(
        AddExpiryListingsAsyncRequestExpiryListings ExpiryListings
    )
    {
        this.ExpiryListings = ExpiryListings;
    }
}
