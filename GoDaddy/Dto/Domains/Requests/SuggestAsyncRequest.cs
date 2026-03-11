using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class SuggestAsyncRequest
{
    public string? XShopperId { get; }
    public string? Query { get; }
    public string? Country { get; }
    public string? City { get; }
    public IReadOnlyList<string>? Sources { get; }
    public IReadOnlyList<string>? Tlds { get; }
    public int? LengthMax { get; }
    public int? LengthMin { get; }
    public int? Limit { get; }
    public int? WaitMs { get; }

    public SuggestAsyncRequest(
        string? XShopperId,
        string? Query,
        string? Country,
        string? City,
        IReadOnlyList<string>? Sources,
        IReadOnlyList<string>? Tlds,
        int? LengthMax,
        int? LengthMin,
        int? Limit,
        int? WaitMs
    )
    {
        this.XShopperId = XShopperId;
        this.Query = Query;
        this.Country = Country;
        this.City = City;
        this.Sources = Sources;
        this.Tlds = Tlds;
        this.LengthMax = LengthMax;
        this.LengthMin = LengthMin;
        this.Limit = Limit;
        this.WaitMs = WaitMs;
    }
}
