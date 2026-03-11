namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class RenewAsyncRequestBody
{
    public int? Period { get; }

    public RenewAsyncRequestBody(
        int? Period
    )
    {
        this.Period = Period;
    }
}
