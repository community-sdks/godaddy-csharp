
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RecordReplaceTypeNameAsyncRequest
{
    public string? XShopperId { get; }
    public string Domain { get; }
    public string Type { get; }
    public string Name { get; }
    public RecordReplaceTypeNameAsyncRequestRecords Records { get; }

    public RecordReplaceTypeNameAsyncRequest(
        string? XShopperId,
        string Domain,
        string Type,
        string Name,
        RecordReplaceTypeNameAsyncRequestRecords Records
    )
    {
        this.XShopperId = XShopperId;
        this.Domain = Domain;
        this.Type = Type;
        this.Name = Name;
        this.Records = Records;
    }
}
