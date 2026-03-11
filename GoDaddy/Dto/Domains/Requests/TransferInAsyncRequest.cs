
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class TransferInAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public TransferInAsyncRequestBody Body { get; }

    public TransferInAsyncRequest(
        string? XShopperId,
        string Domain,
        TransferInAsyncRequestBody Body
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Body = Body;
    }
}
