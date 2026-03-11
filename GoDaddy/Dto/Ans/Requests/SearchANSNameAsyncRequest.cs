using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class SearchANSNameAsyncRequest
{
    public string? AgentDisplayName { get; }
    public string? Version { get; }
    public string? AgentHost { get; }
    public string? Protocol { get; }
    public int? Limit { get; }
    public int? Offset { get; }

    public SearchANSNameAsyncRequest(
        string? AgentDisplayName,
        string? Version,
        string? AgentHost,
        string? Protocol,
        int? Limit,
        int? Offset
    )
    {
        this.AgentDisplayName = AgentDisplayName;
        this.Version = Version;
        this.AgentHost = AgentHost;
        this.Protocol = Protocol;
        this.Limit = Limit;
        this.Offset = Offset;
    }
}
