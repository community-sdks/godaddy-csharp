using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncRequest
{
    public string? XRequestId { get; }
    public string CustomerId { get; }
    public string NotificationId { get; }

    public PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncRequest(
        string? XRequestId,
        string CustomerId,
        string NotificationId
    )
    {
        this.XRequestId = XRequestId;
        this.CustomerId = CustomerId;
        this.NotificationId = NotificationId;
    }
}
