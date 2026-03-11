using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class ListAsyncRequest
{
    public string? XShopperId { get; }
    public IReadOnlyList<string>? Statuses { get; }
    public IReadOnlyList<string>? StatusGroups { get; }
    public int? Limit { get; }
    public string? Marker { get; }
    public IReadOnlyList<string>? Includes { get; }
    public string? ModifiedDate { get; }

    public ListAsyncRequest(
        string? XShopperId,
        IReadOnlyList<string>? Statuses,
        IReadOnlyList<string>? StatusGroups,
        int? Limit,
        string? Marker,
        IReadOnlyList<string>? Includes,
        string? ModifiedDate
    )
    {
        this.XShopperId = XShopperId;
        this.Statuses = Statuses;
        this.StatusGroups = StatusGroups;
        this.Limit = Limit;
        this.Marker = Marker;
        this.Includes = Includes;
        this.ModifiedDate = ModifiedDate;
    }
}
