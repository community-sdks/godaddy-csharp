using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Dto.Agreements.Requests;
using CommunitySdks.GoDaddy.Dto.Agreements.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Agreements;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AgreementsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AgreementsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<GetAsyncResponse> GetAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/agreements",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("keys", request.Keys),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Private-Label-Id", request.XPrivateLabelId),
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAsyncResponse> GetAsync(int? XPrivateLabelId, string? XMarketId, IReadOnlyList<string> Keys, CancellationToken cancellationToken = default)
    {
        return GetAsync(new GetAsyncRequest(XPrivateLabelId: XPrivateLabelId, XMarketId: XMarketId, Keys: Keys), cancellationToken);
    }

    private AgreementsApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new AgreementsBadRequestException(exception),
            401 => new AgreementsUnauthorizedException(exception),
            403 => new AgreementsForbiddenException(exception),
            404 => new AgreementsNotFoundException(exception),
            409 => new AgreementsConflictException(exception),
            422 => new AgreementsUnprocessableEntityException(exception),
            429 => new AgreementsRateLimitException(exception),
            504 => new AgreementsGatewayTimeoutException(exception),
            _ => new AgreementsServerException(exception),
        };
    }
}
