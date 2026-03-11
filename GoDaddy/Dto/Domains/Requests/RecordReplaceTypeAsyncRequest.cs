
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordReplaceTypeAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public string Type { get; }
    public RecordReplaceTypeAsyncRequestRecords Records { get; }

    public RecordReplaceTypeAsyncRequest(
        string? XShopperId,
        string Domain,
        string Type,
        RecordReplaceTypeAsyncRequestRecords Records
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Type = Type;
        this.Records = Records;
    }
}
