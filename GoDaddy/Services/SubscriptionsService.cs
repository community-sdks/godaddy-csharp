using CommunitySdks.GoDaddy.Dto.Subscriptions.Requests;
using CommunitySdks.GoDaddy.Dto.Subscriptions.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Subscriptions;

namespace CommunitySdks.GoDaddy.Services;

public sealed class SubscriptionsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public SubscriptionsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<ListAsyncResponse> ListAsync(ListAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/subscriptions",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("productGroupKeys", request.ProductGroupKeys),
                new KeyValuePair<string, object?>("includes", request.Includes),
                new KeyValuePair<string, object?>("offset", request.Offset),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("sort", request.Sort),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return ListAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ListAsyncResponse> ListAsync(string XAppKey, string? XShopperId, string? XMarketId, IReadOnlyList<string>? ProductGroupKeys, IReadOnlyList<string>? Includes, int? Offset, int? Limit, string? Sort, CancellationToken cancellationToken = default)
    {
        return ListAsync(new ListAsyncRequest(XAppKey: XAppKey, XShopperId: XShopperId, XMarketId: XMarketId, ProductGroupKeys: ProductGroupKeys, Includes: Includes, Offset: Offset, Limit: Limit, Sort: Sort), cancellationToken);
    }

    public async Task<ProductGroupsAsyncResponse> ProductGroupsAsync(ProductGroupsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/subscriptions/productGroups",
                null,
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return ProductGroupsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ProductGroupsAsyncResponse> ProductGroupsAsync(string XAppKey, string? XShopperId, CancellationToken cancellationToken = default)
    {
        return ProductGroupsAsync(new ProductGroupsAsyncRequest(XAppKey: XAppKey, XShopperId: XShopperId), cancellationToken);
    }

    public async Task<CancelAsyncResponse> CancelAsync(CancelAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/subscriptions/{subscriptionId}",
                new[]
            {
                new KeyValuePair<string, object?>("subscriptionId", request.SubscriptionId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return CancelAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CancelAsyncResponse> CancelAsync(string XAppKey, string? XShopperId, string SubscriptionId, CancellationToken cancellationToken = default)
    {
        return CancelAsync(new CancelAsyncRequest(XAppKey: XAppKey, XShopperId: XShopperId, SubscriptionId: SubscriptionId), cancellationToken);
    }

    public async Task<GetAsyncResponse> GetAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/subscriptions/{subscriptionId}",
                new[]
            {
                new KeyValuePair<string, object?>("subscriptionId", request.SubscriptionId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
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

    public Task<GetAsyncResponse> GetAsync(string XAppKey, string? XShopperId, string SubscriptionId, CancellationToken cancellationToken = default)
    {
        return GetAsync(new GetAsyncRequest(XAppKey: XAppKey, XShopperId: XShopperId, SubscriptionId: SubscriptionId), cancellationToken);
    }

    public async Task<UpdateAsyncResponse> UpdateAsync(UpdateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v1/subscriptions/{subscriptionId}",
                new[]
            {
                new KeyValuePair<string, object?>("subscriptionId", request.SubscriptionId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Subscription,
                cancellationToken).ConfigureAwait(false);

            return UpdateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<UpdateAsyncResponse> UpdateAsync(string XAppKey, string? XShopperId, string SubscriptionId, UpdateAsyncRequestSubscription Subscription, CancellationToken cancellationToken = default)
    {
        return UpdateAsync(new UpdateAsyncRequest(XAppKey: XAppKey, XShopperId: XShopperId, SubscriptionId: SubscriptionId, Subscription: Subscription), cancellationToken);
    }

    private SubscriptionsApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new SubscriptionsBadRequestException(exception),
            401 => new SubscriptionsUnauthorizedException(exception),
            403 => new SubscriptionsForbiddenException(exception),
            404 => new SubscriptionsNotFoundException(exception),
            409 => new SubscriptionsConflictException(exception),
            422 => new SubscriptionsUnprocessableEntityException(exception),
            429 => new SubscriptionsRateLimitException(exception),
            504 => new SubscriptionsGatewayTimeoutException(exception),
            _ => new SubscriptionsServerException(exception),
        };
    }
}
