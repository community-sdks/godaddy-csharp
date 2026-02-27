using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class ShoppersService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public ShoppersService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> CreateSubaccountAsync(object Subaccount, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/shoppers/subaccount",
            null,
            null,
            null,
            Subaccount,
            cancellationToken);
    }

    public Task<JsonNode?> GetAsync(object ShopperId, object? Includes, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/shoppers/{shopperId}",
            new[]
        {
            new KeyValuePair<string, object?>("shopperId", ShopperId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("includes", Includes),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> UpdateAsync(object ShopperId, object Shopper, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/shoppers/{shopperId}",
            new[]
        {
            new KeyValuePair<string, object?>("shopperId", ShopperId),
        },
            null,
            null,
            Shopper,
            cancellationToken);
    }

    public Task<JsonNode?> DeleteAsync(object ShopperId, object AuditClientIp, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/shoppers/{shopperId}",
            new[]
        {
            new KeyValuePair<string, object?>("shopperId", ShopperId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("auditClientIp", AuditClientIp),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetStatusAsync(object ShopperId, object AuditClientIp, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/shoppers/{shopperId}/status",
            new[]
        {
            new KeyValuePair<string, object?>("shopperId", ShopperId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("auditClientIp", AuditClientIp),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> ChangePasswordAsync(object ShopperId, object Secret, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v1/shoppers/{shopperId}/factors/password",
            new[]
        {
            new KeyValuePair<string, object?>("shopperId", ShopperId),
        },
            null,
            null,
            Secret,
            cancellationToken);
    }
}
