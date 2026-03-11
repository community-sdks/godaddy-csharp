using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordGetAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public string Type { get; }
    public string Name { get; }
    public int? Offset { get; }
    public int? Limit { get; }

    public RecordGetAsyncRequest(
        string? XShopperId,
        string Domain,
        string Type,
        string Name,
        int? Offset,
        int? Limit
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Type = Type;
        this.Name = Name;
        this.Offset = Offset;
        this.Limit = Limit;
    }
}
