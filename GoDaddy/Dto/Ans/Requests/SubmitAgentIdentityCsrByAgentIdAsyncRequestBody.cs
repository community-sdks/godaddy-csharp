namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class SubmitAgentIdentityCsrByAgentIdAsyncRequestBody
{
    public string CsrPEM { get; }

    public SubmitAgentIdentityCsrByAgentIdAsyncRequestBody(
        string CsrPEM
    )
    {
        this.CsrPEM = CsrPEM;
    }
}
