namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class ResolveANSNameAsyncRequestBody
{
    public string AgentHost { get; }
    public string Version { get; }

    public ResolveANSNameAsyncRequestBody(
        string AgentHost,
        string Version
    )
    {
        this.AgentHost = AgentHost;
        this.Version = Version;
    }
}
