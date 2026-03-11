using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordDeleteTypeNameAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public string Type { get; }
    public string Name { get; }

    public RecordDeleteTypeNameAsyncRequest(
        string? XShopperId,
        string Domain,
        string Type,
        string Name
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Type = Type;
        this.Name = Name;
    }
}
