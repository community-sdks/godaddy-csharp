namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class UpdateAsyncRequestShopper
{
    public string? Email { get; }
    public int? ExternalId { get; }
    public string? MarketId { get; }
    public string? NameFirst { get; }
    public string? NameLast { get; }

    public UpdateAsyncRequestShopper(
        string? Email,
        int? ExternalId,
        string? MarketId,
        string? NameFirst,
        string? NameLast
    )
    {
        this.Email = Email;
        this.ExternalId = ExternalId;
        this.MarketId = MarketId;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
    }
}
