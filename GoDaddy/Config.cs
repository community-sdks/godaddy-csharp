namespace CommunitySdks.GoDaddy;

public sealed class Config
{
    public string? ApiKey { get; init; }
    public string? ApiSecret { get; init; }
    public string? BaseUrl { get; init; }
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);
    public int MaxRetries { get; init; } = 2;
    public TimeSpan RetryDelay { get; init; } = TimeSpan.FromMilliseconds(200);
    public IReadOnlyDictionary<string, string> DefaultHeaders { get; init; } = new Dictionary<string, string>();
    public string UserAgent { get; init; } = "community-sdks/godaddy-csharp";
}
