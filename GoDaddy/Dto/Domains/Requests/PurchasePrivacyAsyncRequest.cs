
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PurchasePrivacyAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public PurchasePrivacyAsyncRequestBody Body { get; }

    public PurchasePrivacyAsyncRequest(
        string? XShopperId,
        string Domain,
        PurchasePrivacyAsyncRequestBody Body
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
