using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class GetTicketInfoAsyncRequest
{
    public string TicketId { get; }

    public GetTicketInfoAsyncRequest(
        string TicketId
    )
    {
        this.TicketId = TicketId;
    }
}
