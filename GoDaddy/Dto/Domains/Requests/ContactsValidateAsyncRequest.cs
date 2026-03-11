
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class ContactsValidateAsyncRequest
{
    public int? XPrivateLabelId { get; }
    public string? MarketId { get; }
    public ContactsValidateAsyncRequestBody Body { get; }

    public ContactsValidateAsyncRequest(
        int? XPrivateLabelId,
        string? MarketId,
        ContactsValidateAsyncRequestBody Body
    )
    {
        this.XPrivateLabelId = XPrivateLabelId;
        this.MarketId = MarketId;
        this.Body = Body;
    }
}
