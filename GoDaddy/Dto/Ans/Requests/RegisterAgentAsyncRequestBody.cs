namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class RegisterAgentAsyncRequestBodyEndpointsItemFunctionsItem
{
    public string Id { get; }
    public string Name { get; }
    public IReadOnlyList<string>? Tags { get; }

    public RegisterAgentAsyncRequestBodyEndpointsItemFunctionsItem(
        string Id,
        string Name,
        IReadOnlyList<string>? Tags
    )
    {
        this.Id = Id;
        this.Name = Name;
        this.Tags = Tags;
    }
}

public sealed class RegisterAgentAsyncRequestBodyEndpointsItem
{
    public string AgentUrl { get; }
    public string? MetaDataUrl { get; }
    public string? DocumentationUrl { get; }
    public string Protocol { get; }
    public IReadOnlyList<RegisterAgentAsyncRequestBodyEndpointsItemFunctionsItem>? Functions { get; }
    public IReadOnlyList<string>? Transports { get; }

    public RegisterAgentAsyncRequestBodyEndpointsItem(
        string AgentUrl,
        string? MetaDataUrl,
        string? DocumentationUrl,
        string Protocol,
        IReadOnlyList<RegisterAgentAsyncRequestBodyEndpointsItemFunctionsItem>? Functions,
        IReadOnlyList<string>? Transports
    )
    {
        this.AgentUrl = AgentUrl;
        this.MetaDataUrl = MetaDataUrl;
        this.DocumentationUrl = DocumentationUrl;
        this.Protocol = Protocol;
        this.Functions = Functions;
        this.Transports = Transports;
    }
}

public sealed class RegisterAgentAsyncRequestBody
{
    public string? AgentDescription { get; }
    public string AgentDisplayName { get; }
    public string AgentHost { get; }
    public IReadOnlyList<RegisterAgentAsyncRequestBodyEndpointsItem> Endpoints { get; }
    public string IdentityCsrPEM { get; }
    public string? ServerCertificateChainPEM { get; }
    public string? ServerCertificatePEM { get; }
    public string? ServerCsrPEM { get; }
    public string Version { get; }

    public RegisterAgentAsyncRequestBody(
        string? AgentDescription,
        string AgentDisplayName,
        string AgentHost,
        IReadOnlyList<RegisterAgentAsyncRequestBodyEndpointsItem> Endpoints,
        string IdentityCsrPEM,
        string? ServerCertificateChainPEM,
        string? ServerCertificatePEM,
        string? ServerCsrPEM,
        string Version
    )
    {
        this.AgentDescription = AgentDescription;
        this.AgentDisplayName = AgentDisplayName;
        this.AgentHost = AgentHost;
        this.Endpoints = Endpoints;
        this.IdentityCsrPEM = IdentityCsrPEM;
        this.ServerCertificateChainPEM = ServerCertificateChainPEM;
        this.ServerCertificatePEM = ServerCertificatePEM;
        this.ServerCsrPEM = ServerCsrPEM;
        this.Version = Version;
    }
}
