namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class SubmitAgentServerCsrByAgentIdAsyncRequestBody
{
    public string CsrPEM { get; }

    public SubmitAgentServerCsrByAgentIdAsyncRequestBody(
        string CsrPEM
    )
    {
        this.CsrPEM = CsrPEM;
    }
}
