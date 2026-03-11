using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class GetTicketInfoV2AsyncRequest
{
    public string TicketId { get; }

    public GetTicketInfoV2AsyncRequest(
        string TicketId
    )
    {
        this.TicketId = TicketId;
    }
}
