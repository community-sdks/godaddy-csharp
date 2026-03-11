using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class GetAsyncRequest
{
    public string ShopperId { get; }
    public IReadOnlyList<string>? Includes { get; }

    public GetAsyncRequest(
        string ShopperId,
        IReadOnlyList<string>? Includes
    )
    {
        this.ShopperId = ShopperId;
        this.Includes = Includes;
    }
}
