using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AnsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AnsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> SearchANSNameAsync(object? AgentDisplayName, object? Version, object? AgentHost, object? Protocol, object? Limit, object? Offset, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("agentDisplayName", AgentDisplayName),
            new KeyValuePair<string, object?>("version", Version),
            new KeyValuePair<string, object?>("agentHost", AgentHost),
            new KeyValuePair<string, object?>("protocol", Protocol),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("offset", Offset),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> RegisterAgentAsync(object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/register",
            null,
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> ResolveANSNameAsync(object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/resolution",
            null,
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgentAsync(object AgentId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents/{agentId}",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> ValidateRegistrationAsync(object AgentId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/{agentId}/verify-acme",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> VerifyDnsRecordsAsync(object AgentId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/{agentId}/verify-dns",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgentIdentityCertificateByAgentIdAsync(object AgentId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents/{agentId}/certificates/identity",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> SubmitAgentIdentityCsrByAgentIdAsync(object AgentId, object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/{agentId}/certificates/identity",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgentServerCertificateByAgentIdAsync(object AgentId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents/{agentId}/certificates/server",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> SubmitAgentServerCsrByAgentIdAsync(object AgentId, object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/agents/{agentId}/certificates/server",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
        },
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgentCsrStatusByAgentIdAsync(object AgentId, object CsrId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents/{agentId}/csrs/{csrId}/status",
            new[]
        {
            new KeyValuePair<string, object?>("agentId", AgentId),
            new KeyValuePair<string, object?>("csrId", CsrId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgentEventsAsync(object? XRequestId, object? ProviderId, object? LastLogId, object? Limit, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/agents/events",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("providerId", ProviderId),
            new KeyValuePair<string, object?>("lastLogId", LastLogId),
            new KeyValuePair<string, object?>("limit", Limit),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }
}
