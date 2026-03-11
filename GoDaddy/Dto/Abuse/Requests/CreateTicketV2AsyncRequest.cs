namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class CreateTicketV2AsyncRequest
{
    public CreateTicketV2Body Body { get; }

    public CreateTicketV2AsyncRequest(
        CreateTicketV2Body Body
    )
    {
        this.Body = Body;
    }
}
