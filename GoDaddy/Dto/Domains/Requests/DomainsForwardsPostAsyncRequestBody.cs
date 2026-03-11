namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsPostAsyncRequestBodyMask
{
    public string? Title { get; }
    public string? Description { get; }
    public string? Keywords { get; }

    public DomainsForwardsPostAsyncRequestBodyMask(
        string? Title,
        string? Description,
        string? Keywords
    )
    {
        this.Title = Title;
        this.Description = Description;
        this.Keywords = Keywords;
    }
}

public sealed class DomainsForwardsPostAsyncRequestBody
{
    public string Type { get; }
    public string Url { get; }
    public DomainsForwardsPostAsyncRequestBodyMask? Mask { get; }

    public DomainsForwardsPostAsyncRequestBody(
        string Type,
        string Url,
        DomainsForwardsPostAsyncRequestBodyMask? Mask
    )
    {
        this.Type = Type;
        this.Url = Url;
        this.Mask = Mask;
    }
}
