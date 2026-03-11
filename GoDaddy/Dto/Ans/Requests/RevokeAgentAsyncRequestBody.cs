namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class RevokeAgentAsyncRequestBody
{
    public string Reason { get; }
    public string? Comments { get; }

    public RevokeAgentAsyncRequestBody(
        string Reason,
        string? Comments
    )
    {
        this.Reason = Reason;
        this.Comments = Comments;
    }
}
