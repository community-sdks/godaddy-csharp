
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PurchaseAsyncRequest
{
    public string? XShopperId { get; }
    public PurchaseAsyncRequestBody Body { get; }

    public PurchaseAsyncRequest(
        string? XShopperId,
        PurchaseAsyncRequestBody Body
    )
    {
        this.XShopperId = XShopperId;
        this.Body = Body;
    }
}
