using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Dto.Ans.Requests;

public sealed class VerifyDnsRecordsAsyncRequest
{
    public string AgentId { get; }

    public VerifyDnsRecordsAsyncRequest(
        string AgentId
    )
    {
        this.AgentId = AgentId;
    }
}
