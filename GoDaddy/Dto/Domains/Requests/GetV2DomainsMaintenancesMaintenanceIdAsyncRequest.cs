using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetV2DomainsMaintenancesMaintenanceIdAsyncRequest
{
    public string? XRequestId { get; }
    public string MaintenanceId { get; }

    public GetV2DomainsMaintenancesMaintenanceIdAsyncRequest(
        string? XRequestId,
        string MaintenanceId
    )
    {
        this.XRequestId = XRequestId;
        this.MaintenanceId = MaintenanceId;
    }
}
