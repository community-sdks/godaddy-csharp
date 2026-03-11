using CommunitySdks.GoDaddy.Dto.Aftermarket.Requests;
using CommunitySdks.GoDaddy.Dto.Aftermarket.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Aftermarket;

namespace CommunitySdks.GoDaddy.Services;

public sealed class AftermarketService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public AftermarketService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<GetListingsAsyncResponse> GetListingsAsync(GetListingsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/customers/{customerId}/auctions/listings",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("domains", request.Domains),
                new KeyValuePair<string, object?>("listingStatus", request.ListingStatus),
                new KeyValuePair<string, object?>("transferBefore", request.TransferBefore),
                new KeyValuePair<string, object?>("transferAfter", request.TransferAfter),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("offset", request.Offset),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetListingsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetListingsAsyncResponse> GetListingsAsync(string CustomerId, string? Domains, string? ListingStatus, string? TransferBefore, string? TransferAfter, int? Limit, int? Offset, CancellationToken cancellationToken = default)
    {
        return GetListingsAsync(new GetListingsAsyncRequest(CustomerId: CustomerId, Domains: Domains, ListingStatus: ListingStatus, TransferBefore: TransferBefore, TransferAfter: TransferAfter, Limit: Limit, Offset: Offset), cancellationToken);
    }

    public async Task<DeleteListingsAsyncResponse> DeleteListingsAsync(DeleteListingsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/aftermarket/listings",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("domains", request.Domains),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return DeleteListingsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DeleteListingsAsyncResponse> DeleteListingsAsync(IReadOnlyList<string> Domains, CancellationToken cancellationToken = default)
    {
        return DeleteListingsAsync(new DeleteListingsAsyncRequest(Domains: Domains), cancellationToken);
    }

    public async Task<AddExpiryListingsAsyncResponse> AddExpiryListingsAsync(AddExpiryListingsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/aftermarket/listings/expiry",
                null,
                null,
                null,
                request.ExpiryListings,
                cancellationToken).ConfigureAwait(false);

            return AddExpiryListingsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<AddExpiryListingsAsyncResponse> AddExpiryListingsAsync(AddExpiryListingsAsyncRequestExpiryListings ExpiryListings, CancellationToken cancellationToken = default)
    {
        return AddExpiryListingsAsync(new AddExpiryListingsAsyncRequest(ExpiryListings: ExpiryListings), cancellationToken);
    }

    private AftermarketApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new AftermarketBadRequestException(exception),
            401 => new AftermarketUnauthorizedException(exception),
            403 => new AftermarketForbiddenException(exception),
            404 => new AftermarketNotFoundException(exception),
            409 => new AftermarketConflictException(exception),
            422 => new AftermarketUnprocessableEntityException(exception),
            429 => new AftermarketRateLimitException(exception),
            504 => new AftermarketGatewayTimeoutException(exception),
            _ => new AftermarketServerException(exception),
        };
    }
}
