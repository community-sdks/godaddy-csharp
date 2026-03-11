
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class UpdateAsyncRequest
{
    public string Domain { get; }
    public string? XShopperId { get; }
    public UpdateAsyncRequestBody Body { get; }

    public UpdateAsyncRequest(
        string Domain,
        string? XShopperId,
        UpdateAsyncRequestBody Body
    )
    {
        this.Domain = Domain;
        this.XShopperId = XShopperId;
        this.Body = Body;
    }
}
