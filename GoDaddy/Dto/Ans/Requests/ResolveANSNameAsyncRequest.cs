
namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class ResolveANSNameAsyncRequest
{
    public ResolveANSNameAsyncRequestBody Body { get; }

    public ResolveANSNameAsyncRequest(
        ResolveANSNameAsyncRequestBody Body
    )
    {
        this.Body = Body;
    }
}
