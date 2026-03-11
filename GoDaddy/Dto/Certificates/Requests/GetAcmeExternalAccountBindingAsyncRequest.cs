using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class GetAcmeExternalAccountBindingAsyncRequest
{
    public string? Param1 { get; }

    public GetAcmeExternalAccountBindingAsyncRequest(
        string? Param1
    )
    {
        this.Param1 = Param1;
    }
}
