using CommunitySdks.GoDaddy.Dto.Ans.Requests;
using CommunitySdks.GoDaddy.Dto.Ans.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Ans;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AnsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AnsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<SearchANSNameAsyncResponse> SearchANSNameAsync(SearchANSNameAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("agentDisplayName", request.AgentDisplayName),
                new KeyValuePair<string, object?>("version", request.Version),
                new KeyValuePair<string, object?>("agentHost", request.AgentHost),
                new KeyValuePair<string, object?>("protocol", request.Protocol),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return SearchANSNameAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<SearchANSNameAsyncResponse> SearchANSNameAsync(string? AgentDisplayName, string? Version, string? AgentHost, string? Protocol, int? Limit, int? Offset, CancellationToken cancellationToken = default)
    {
        return SearchANSNameAsync(new SearchANSNameAsyncRequest(AgentDisplayName: AgentDisplayName, Version: Version, AgentHost: AgentHost, Protocol: Protocol, Limit: Limit, Offset: Offset), cancellationToken);
    }

    public async Task<RegisterAgentAsyncResponse> RegisterAgentAsync(RegisterAgentAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/register",
                null,
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return RegisterAgentAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RegisterAgentAsyncResponse> RegisterAgentAsync(RegisterAgentAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return RegisterAgentAsync(new RegisterAgentAsyncRequest(Body: Body), cancellationToken);
    }

    public async Task<ResolveANSNameAsyncResponse> ResolveANSNameAsync(ResolveANSNameAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/resolution",
                null,
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return ResolveANSNameAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ResolveANSNameAsyncResponse> ResolveANSNameAsync(ResolveANSNameAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return ResolveANSNameAsync(new ResolveANSNameAsyncRequest(Body: Body), cancellationToken);
    }

    public async Task<GetAgentAsyncResponse> GetAgentAsync(GetAgentAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents/{agentId}",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgentAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgentAsyncResponse> GetAgentAsync(string AgentId, CancellationToken cancellationToken = default)
    {
        return GetAgentAsync(new GetAgentAsyncRequest(AgentId: AgentId), cancellationToken);
    }

    public async Task<RevokeAgentAsyncResponse> RevokeAgentAsync(RevokeAgentAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/{agentId}/revoke",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return RevokeAgentAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RevokeAgentAsyncResponse> RevokeAgentAsync(string AgentId, RevokeAgentAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return RevokeAgentAsync(new RevokeAgentAsyncRequest(AgentId: AgentId, Body: Body), cancellationToken);
    }

    public async Task<ValidateRegistrationAsyncResponse> ValidateRegistrationAsync(ValidateRegistrationAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/{agentId}/verify-acme",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return ValidateRegistrationAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ValidateRegistrationAsyncResponse> ValidateRegistrationAsync(string AgentId, CancellationToken cancellationToken = default)
    {
        return ValidateRegistrationAsync(new ValidateRegistrationAsyncRequest(AgentId: AgentId), cancellationToken);
    }

    public async Task<VerifyDnsRecordsAsyncResponse> VerifyDnsRecordsAsync(VerifyDnsRecordsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/{agentId}/verify-dns",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return VerifyDnsRecordsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<VerifyDnsRecordsAsyncResponse> VerifyDnsRecordsAsync(string AgentId, CancellationToken cancellationToken = default)
    {
        return VerifyDnsRecordsAsync(new VerifyDnsRecordsAsyncRequest(AgentId: AgentId), cancellationToken);
    }

    public async Task<GetAgentIdentityCertificateByAgentIdAsyncResponse> GetAgentIdentityCertificateByAgentIdAsync(GetAgentIdentityCertificateByAgentIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents/{agentId}/certificates/identity",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgentIdentityCertificateByAgentIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgentIdentityCertificateByAgentIdAsyncResponse> GetAgentIdentityCertificateByAgentIdAsync(string AgentId, CancellationToken cancellationToken = default)
    {
        return GetAgentIdentityCertificateByAgentIdAsync(new GetAgentIdentityCertificateByAgentIdAsyncRequest(AgentId: AgentId), cancellationToken);
    }

    public async Task<SubmitAgentIdentityCsrByAgentIdAsyncResponse> SubmitAgentIdentityCsrByAgentIdAsync(SubmitAgentIdentityCsrByAgentIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/{agentId}/certificates/identity",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return SubmitAgentIdentityCsrByAgentIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<SubmitAgentIdentityCsrByAgentIdAsyncResponse> SubmitAgentIdentityCsrByAgentIdAsync(string AgentId, SubmitAgentIdentityCsrByAgentIdAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return SubmitAgentIdentityCsrByAgentIdAsync(new SubmitAgentIdentityCsrByAgentIdAsyncRequest(AgentId: AgentId, Body: Body), cancellationToken);
    }

    public async Task<GetAgentServerCertificateByAgentIdAsyncResponse> GetAgentServerCertificateByAgentIdAsync(GetAgentServerCertificateByAgentIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents/{agentId}/certificates/server",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgentServerCertificateByAgentIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgentServerCertificateByAgentIdAsyncResponse> GetAgentServerCertificateByAgentIdAsync(string AgentId, CancellationToken cancellationToken = default)
    {
        return GetAgentServerCertificateByAgentIdAsync(new GetAgentServerCertificateByAgentIdAsyncRequest(AgentId: AgentId), cancellationToken);
    }

    public async Task<SubmitAgentServerCsrByAgentIdAsyncResponse> SubmitAgentServerCsrByAgentIdAsync(SubmitAgentServerCsrByAgentIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/agents/{agentId}/certificates/server",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
            },
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return SubmitAgentServerCsrByAgentIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<SubmitAgentServerCsrByAgentIdAsyncResponse> SubmitAgentServerCsrByAgentIdAsync(string AgentId, SubmitAgentServerCsrByAgentIdAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return SubmitAgentServerCsrByAgentIdAsync(new SubmitAgentServerCsrByAgentIdAsyncRequest(AgentId: AgentId, Body: Body), cancellationToken);
    }

    public async Task<GetAgentCsrStatusByAgentIdAsyncResponse> GetAgentCsrStatusByAgentIdAsync(GetAgentCsrStatusByAgentIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents/{agentId}/csrs/{csrId}/status",
                new[]
            {
                new KeyValuePair<string, object?>("agentId", request.AgentId),
                new KeyValuePair<string, object?>("csrId", request.CsrId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgentCsrStatusByAgentIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgentCsrStatusByAgentIdAsyncResponse> GetAgentCsrStatusByAgentIdAsync(string AgentId, string CsrId, CancellationToken cancellationToken = default)
    {
        return GetAgentCsrStatusByAgentIdAsync(new GetAgentCsrStatusByAgentIdAsyncRequest(AgentId: AgentId, CsrId: CsrId), cancellationToken);
    }

    public async Task<GetAgentEventsAsyncResponse> GetAgentEventsAsync(GetAgentEventsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agents/events",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("providerId", request.ProviderId),
                new KeyValuePair<string, object?>("lastLogId", request.LastLogId),
                new KeyValuePair<string, object?>("limit", request.Limit),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgentEventsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgentEventsAsyncResponse> GetAgentEventsAsync(string? XRequestId, string? ProviderId, string? LastLogId, int? Limit, CancellationToken cancellationToken = default)
    {
        return GetAgentEventsAsync(new GetAgentEventsAsyncRequest(XRequestId: XRequestId, ProviderId: ProviderId, LastLogId: LastLogId, Limit: Limit), cancellationToken);
    }

    private AnsApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new AnsBadRequestException(exception),
            401 => new AnsUnauthorizedException(exception),
            403 => new AnsForbiddenException(exception),
            404 => new AnsNotFoundException(exception),
            409 => new AnsConflictException(exception),
            422 => new AnsUnprocessableEntityException(exception),
            429 => new AnsRateLimitException(exception),
            504 => new AnsGatewayTimeoutException(exception),
            _ => new AnsServerException(exception),
        };
    }
}
