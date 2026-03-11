using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class DeleteAsyncRequest
{
    public string ShopperId { get; }
    public string AuditClientIp { get; }

    public DeleteAsyncRequest(
        string ShopperId,
        string AuditClientIp
    )
    {
        this.ShopperId = ShopperId;
        this.AuditClientIp = AuditClientIp;
    }
}
