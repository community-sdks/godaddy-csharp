namespace CommunitySdks.GoDaddy.Dto.Abuse.Requests;

public sealed class CreateTicketLegacyBody
{
    public string Source { get; }
    public string Type { get; }
    public string? Target { get; }
    public string? Info { get; }
    public string? InfoUrl { get; }
    public bool? Intentional { get; }
    public string? Proxy { get; }

    public CreateTicketLegacyBody(
        string Source,
        string Type,
        string? Target = null,
        string? Info = null,
        string? InfoUrl = null,
        bool? Intentional = null,
        string? Proxy = null
    )
    {
        this.Source = Source;
        this.Type = Type;
        this.Target = Target;
        this.Info = Info;
        this.InfoUrl = InfoUrl;
        this.Intentional = Intentional;
        this.Proxy = Proxy;
    }
}

public sealed class CreateTicketV2Body
{
    public string Source { get; }
    public string Type { get; }
    public string? Target { get; }
    public string? Info { get; }
    public string? InfoUrl { get; }
    public string? Proxy { get; }
    public string? Useragent { get; }

    public CreateTicketV2Body(
        string Source,
        string Type,
        string? Target = null,
        string? Info = null,
        string? InfoUrl = null,
        string? Proxy = null,
        string? Useragent = null
    )
    {
        this.Source = Source;
        this.Type = Type;
        this.Target = Target;
        this.Info = Info;
        this.InfoUrl = InfoUrl;
        this.Proxy = Proxy;
        this.Useragent = Useragent;
    }
}
