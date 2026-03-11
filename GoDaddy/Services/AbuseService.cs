using CommunitySdks.GoDaddy.Dto.Abuse.Requests;
using CommunitySdks.GoDaddy.Dto.Abuse.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Abuse;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AbuseService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AbuseService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<GetTicketsAsyncResponse> GetTicketsAsync(GetTicketsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/abuse/tickets",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("type", request.Type),
                new KeyValuePair<string, object?>("closed", request.Closed),
                new KeyValuePair<string, object?>("sourceDomainOrIp", request.SourceDomainOrIp),
                new KeyValuePair<string, object?>("target", request.Target),
                new KeyValuePair<string, object?>("createdStart", request.CreatedStart),
                new KeyValuePair<string, object?>("createdEnd", request.CreatedEnd),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetTicketsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetTicketsAsyncResponse> GetTicketsAsync(string? Type, bool? Closed, string? SourceDomainOrIp, string? Target, string? CreatedStart, string? CreatedEnd, int? Limit, int? Offset, CancellationToken cancellationToken = default)
    {
        return GetTicketsAsync(new GetTicketsAsyncRequest(Type: Type, Closed: Closed, SourceDomainOrIp: SourceDomainOrIp, Target: Target, CreatedStart: CreatedStart, CreatedEnd: CreatedEnd, Limit: Limit, Offset: Offset), cancellationToken);
    }

    public async Task<CreateTicketAsyncResponse> CreateTicketAsync(CreateTicketAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/abuse/tickets",
                null,
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return CreateTicketAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CreateTicketAsyncResponse> CreateTicketAsync(CreateTicketLegacyBody Body, CancellationToken cancellationToken = default)
    {
        return CreateTicketAsync(new CreateTicketAsyncRequest(Body: Body), cancellationToken);
    }

    public async Task<GetTicketInfoAsyncResponse> GetTicketInfoAsync(GetTicketInfoAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/abuse/tickets/{ticketId}",
                new[]
            {
                new KeyValuePair<string, object?>("ticketId", request.TicketId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetTicketInfoAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetTicketInfoAsyncResponse> GetTicketInfoAsync(string TicketId, CancellationToken cancellationToken = default)
    {
        return GetTicketInfoAsync(new GetTicketInfoAsyncRequest(TicketId: TicketId), cancellationToken);
    }

    public async Task<GetTicketsV2AsyncResponse> GetTicketsV2Async(GetTicketsV2AsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/abuse/tickets",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("type", request.Type),
                new KeyValuePair<string, object?>("closed", request.Closed),
                new KeyValuePair<string, object?>("sourceDomainOrIp", request.SourceDomainOrIp),
                new KeyValuePair<string, object?>("target", request.Target),
                new KeyValuePair<string, object?>("createdStart", request.CreatedStart),
                new KeyValuePair<string, object?>("createdEnd", request.CreatedEnd),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetTicketsV2AsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetTicketsV2AsyncResponse> GetTicketsV2Async(string? Type, bool? Closed, string? SourceDomainOrIp, string? Target, string? CreatedStart, string? CreatedEnd, int? Limit, int? Offset, CancellationToken cancellationToken = default)
    {
        return GetTicketsV2Async(new GetTicketsV2AsyncRequest(Type: Type, Closed: Closed, SourceDomainOrIp: SourceDomainOrIp, Target: Target, CreatedStart: CreatedStart, CreatedEnd: CreatedEnd, Limit: Limit, Offset: Offset), cancellationToken);
    }

    public async Task<CreateTicketV2AsyncResponse> CreateTicketV2Async(CreateTicketV2AsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/abuse/tickets",
                null,
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return CreateTicketV2AsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CreateTicketV2AsyncResponse> CreateTicketV2Async(CreateTicketV2Body Body, CancellationToken cancellationToken = default)
    {
        return CreateTicketV2Async(new CreateTicketV2AsyncRequest(Body: Body), cancellationToken);
    }

    public async Task<GetTicketInfoV2AsyncResponse> GetTicketInfoV2Async(GetTicketInfoV2AsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/abuse/tickets/{ticketId}",
                new[]
            {
                new KeyValuePair<string, object?>("ticketId", request.TicketId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetTicketInfoV2AsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetTicketInfoV2AsyncResponse> GetTicketInfoV2Async(string TicketId, CancellationToken cancellationToken = default)
    {
        return GetTicketInfoV2Async(new GetTicketInfoV2AsyncRequest(TicketId: TicketId), cancellationToken);
    }

    private AbuseApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new AbuseBadRequestException(exception),
            401 => new AbuseUnauthorizedException(exception),
            403 => new AbuseForbiddenException(exception),
            404 => new AbuseNotFoundException(exception),
            409 => new AbuseConflictException(exception),
            422 => new AbuseUnprocessableEntityException(exception),
            429 => new AbuseRateLimitException(exception),
            504 => new AbuseGatewayTimeoutException(exception),
            _ => new AbuseServerException(exception),
        };
    }
}
