
namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class ValidateAsyncRequest
{
    public ValidateAsyncRequestBody Body { get; }

    public ValidateAsyncRequest(
        ValidateAsyncRequestBody Body
    )
    {
        this.Body = Body;
    }
}
