using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class GetAgreementAsyncRequest
{
    public string? XMarketId { get; }
    public IReadOnlyList<string> Tlds { get; }
    public bool Privacy { get; }
    public bool? ForTransfer { get; }

    public GetAgreementAsyncRequest(
        string? XMarketId,
        IReadOnlyList<string> Tlds,
        bool Privacy,
        bool? ForTransfer
    )
    {
        this.XMarketId = XMarketId;
        this.Tlds = Tlds;
        this.Privacy = Privacy;
        this.ForTransfer = ForTransfer;
    }
}
