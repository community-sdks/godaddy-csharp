namespace CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;

public sealed class UpdateAsyncRequestSubscription
{
    public int? PaymentProfileId { get; }
    public bool? RenewAuto { get; }

    public UpdateAsyncRequestSubscription(
        int? PaymentProfileId,
        bool? RenewAuto
    )
    {
        this.PaymentProfileId = PaymentProfileId;
        this.RenewAuto = RenewAuto;
    }
}
