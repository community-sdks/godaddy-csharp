using CommunitySdks.GoDaddy.Dto.Auctions.Requests;
using CommunitySdks.GoDaddy.Dto.Auctions.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Auctions;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AuctionsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AuctionsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<PlaceBidsAsyncResponse> PlaceBidsAsync(PlaceBidsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/customers/{customerId}/aftermarket/listings/bids",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                null,
                null,
                request.RequestBody,
                cancellationToken).ConfigureAwait(false);

            return PlaceBidsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PlaceBidsAsyncResponse> PlaceBidsAsync(string CustomerId, PlaceBidsAsyncRequestRequestBody RequestBody, CancellationToken cancellationToken = default)
    {
        return PlaceBidsAsync(new PlaceBidsAsyncRequest(CustomerId: CustomerId, RequestBody: RequestBody), cancellationToken);
    }

    private AuctionsApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new AuctionsBadRequestException(exception),
            401 => new AuctionsUnauthorizedException(exception),
            403 => new AuctionsForbiddenException(exception),
            404 => new AuctionsNotFoundException(exception),
            409 => new AuctionsConflictException(exception),
            422 => new AuctionsUnprocessableEntityException(exception),
            429 => new AuctionsRateLimitException(exception),
            504 => new AuctionsGatewayTimeoutException(exception),
            _ => new AuctionsServerException(exception),
        };
    }
}
