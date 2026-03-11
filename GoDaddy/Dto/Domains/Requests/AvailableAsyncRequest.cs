using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class AvailableAsyncRequest
{
    public string Domain { get; }
    public string? CheckType { get; }
    public bool? ForTransfer { get; }

    public AvailableAsyncRequest(
        string Domain,
        string? CheckType,
        bool? ForTransfer
    )
    {
        this.Domain = Domain;
        this.CheckType = CheckType;
        this.ForTransfer = ForTransfer;
    }
}
