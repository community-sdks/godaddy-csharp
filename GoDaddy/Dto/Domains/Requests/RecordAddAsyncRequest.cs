
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordAddAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public RecordAddAsyncRequestRecords Records { get; }

    public RecordAddAsyncRequest(
        string? XShopperId,
        string Domain,
        RecordAddAsyncRequestRecords Records
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Records = Records;
    }
}
