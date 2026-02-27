using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AbuseService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AbuseService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> GetTicketsAsync(object? Type, object? Closed, object? SourceDomainOrIp, object? Target, object? CreatedStart, object? CreatedEnd, object? Limit, object? Offset, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/abuse/tickets",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("closed", Closed),
            new KeyValuePair<string, object?>("sourceDomainOrIp", SourceDomainOrIp),
            new KeyValuePair<string, object?>("target", Target),
            new KeyValuePair<string, object?>("createdStart", CreatedStart),
            new KeyValuePair<string, object?>("createdEnd", CreatedEnd),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CreateTicketAsync(object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/abuse/tickets",
            null,
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetTicketInfoAsync(object TicketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/abuse/tickets/{ticketId}",
            new[]
        {
            new KeyValuePair<string, object?>("ticketId", TicketId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetTicketsV2Async(object? Type, object? Closed, object? SourceDomainOrIp, object? Target, object? CreatedStart, object? CreatedEnd, object? Limit, object? Offset, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/abuse/tickets",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("closed", Closed),
            new KeyValuePair<string, object?>("sourceDomainOrIp", SourceDomainOrIp),
            new KeyValuePair<string, object?>("target", Target),
            new KeyValuePair<string, object?>("createdStart", CreatedStart),
            new KeyValuePair<string, object?>("createdEnd", CreatedEnd),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CreateTicketV2Async(object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/abuse/tickets",
            null,
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetTicketInfoV2Async(object TicketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/abuse/tickets/{ticketId}",
            new[]
        {
            new KeyValuePair<string, object?>("ticketId", TicketId),
        },
            null,
            null,
            null,
            cancellationToken);
    }
}
