using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class GetStatusAsyncRequest
{
    public string ShopperId { get; }
    public string AuditClientIp { get; }

    public GetStatusAsyncRequest(
        string ShopperId,
        string AuditClientIp
    )
    {
        this.ShopperId = ShopperId;
        this.AuditClientIp = AuditClientIp;
    }
}
