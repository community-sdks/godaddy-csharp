using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class GetAgentEventsAsyncRequest
{
    public string? XRequestId { get; }
    public string? ProviderId { get; }
    public string? LastLogId { get; }
    public int? Limit { get; }

    public GetAgentEventsAsyncRequest(
        string? XRequestId,
        string? ProviderId,
        string? LastLogId,
        int? Limit
    )
    {
        this.XRequestId = XRequestId;
        this.ProviderId = ProviderId;
        this.LastLogId = LastLogId;
        this.Limit = Limit;
    }
}
