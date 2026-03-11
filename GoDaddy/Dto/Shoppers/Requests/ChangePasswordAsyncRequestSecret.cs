namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class ChangePasswordAsyncRequestSecret
{
    public string? Secret { get; }

    public ChangePasswordAsyncRequestSecret(
        string? Secret
    )
    {
        this.Secret = Secret;
    }
}
