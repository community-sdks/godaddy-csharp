namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class CreateTicketAsyncRequest
{
    public CreateTicketLegacyBody Body { get; }

    public CreateTicketAsyncRequest(
        CreateTicketLegacyBody Body
    )
    {
        this.Body = Body;
    }
}
