
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordReplaceAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public RecordReplaceAsyncRequestRecords Records { get; }

    public RecordReplaceAsyncRequest(
        string? XShopperId,
        string Domain,
        RecordReplaceAsyncRequestRecords Records
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Records = Records;
    }
}
