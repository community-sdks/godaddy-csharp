using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class GetTicketsAsyncRequest
{
    public string? Type { get; }
    public bool? Closed { get; }
    public string? SourceDomainOrIp { get; }
    public string? Target { get; }
    public string? CreatedStart { get; }
    public string? CreatedEnd { get; }
    public int? Limit { get; }
    public int? Offset { get; }

    public GetTicketsAsyncRequest(
        string? Type,
        bool? Closed,
        string? SourceDomainOrIp,
        string? Target,
        string? CreatedStart,
        string? CreatedEnd,
        int? Limit,
        int? Offset
    )
    {
        this.Type = Type;
        this.Closed = Closed;
        this.SourceDomainOrIp = SourceDomainOrIp;
        this.Target = Target;
        this.CreatedStart = CreatedStart;
        this.CreatedEnd = CreatedEnd;
        this.Limit = Limit;
        this.Offset = Offset;
    }
}
