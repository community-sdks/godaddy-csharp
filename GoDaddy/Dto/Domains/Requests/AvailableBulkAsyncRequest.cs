
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class AvailableBulkAsyncRequest
{
    public AvailableBulkAsyncRequestDomains Domains { get; }
    public string? CheckType { get; }

    public AvailableBulkAsyncRequest(
        AvailableBulkAsyncRequestDomains Domains,
        string? CheckType
    )
    {
        this.Domains = Domains;
        this.CheckType = CheckType;
    }
}
