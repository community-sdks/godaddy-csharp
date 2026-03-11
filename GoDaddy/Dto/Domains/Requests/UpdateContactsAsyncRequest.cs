
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class UpdateContactsAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public UpdateContactsAsyncRequestContacts Contacts { get; }

    public UpdateContactsAsyncRequest(
        string? XShopperId,
        string Domain,
        UpdateContactsAsyncRequestContacts Contacts
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Contacts = Contacts;
    }
}
