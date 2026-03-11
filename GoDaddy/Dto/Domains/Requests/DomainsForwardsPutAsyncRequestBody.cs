namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class DomainsForwardsPutAsyncRequestBodyMask
{
    public string? Title { get; }
    public string? Description { get; }
    public string? Keywords { get; }

    public DomainsForwardsPutAsyncRequestBodyMask(
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

public sealed class DomainsForwardsPutAsyncRequestBody
{
    public string Type { get; }
    public string Url { get; }
    public DomainsForwardsPutAsyncRequestBodyMask? Mask { get; }

    public DomainsForwardsPutAsyncRequestBody(
        string Type,
        string Url,
        DomainsForwardsPutAsyncRequestBodyMask? Mask
    )
    {
        this.Type = Type;
        this.Url = Url;
        this.Mask = Mask;
    }
}
