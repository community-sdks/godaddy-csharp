
namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class ChangePasswordAsyncRequest
{
    public string ShopperId { get; }
    public ChangePasswordAsyncRequestSecret Secret { get; }

    public ChangePasswordAsyncRequest(
        string ShopperId,
        ChangePasswordAsyncRequestSecret Secret
    )
    {
        this.ShopperId = ShopperId;
        this.Secret = Secret;
    }
}
