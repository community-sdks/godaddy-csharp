
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RenewAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public RenewAsyncRequestBody Body { get; }

    public RenewAsyncRequest(
        string? XShopperId,
        string Domain,
        RenewAsyncRequestBody Body
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
