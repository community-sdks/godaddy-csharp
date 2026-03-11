using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Dto.Orders.Requests;
using CommunitySdks.GoDaddy.Dto.Orders.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Orders;

namespace CommunitySdks.GoDaddy.Services;

public sealed class OrdersService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public OrdersService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<ListAsyncResponse> ListAsync(ListAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/orders",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("periodStart", request.PeriodStart),
                new KeyValuePair<string, object?>("periodEnd", request.PeriodEnd),
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("productGroupId", request.ProductGroupId),
                new KeyValuePair<string, object?>("paymentProfileId", request.PaymentProfileId),
                new KeyValuePair<string, object?>("parentOrderId", request.ParentOrderId),
                new KeyValuePair<string, object?>("offset", request.Offset),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("sort", request.Sort),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
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

    public Task<ListAsyncResponse> ListAsync(string? PeriodStart, string? PeriodEnd, string? Domain, int? ProductGroupId, int? PaymentProfileId, string? ParentOrderId, int? Offset, int? Limit, string? Sort, string? XShopperId, string XAppKey, CancellationToken cancellationToken = default)
    {
        return ListAsync(new ListAsyncRequest(PeriodStart: PeriodStart, PeriodEnd: PeriodEnd, Domain: Domain, ProductGroupId: ProductGroupId, PaymentProfileId: PaymentProfileId, ParentOrderId: ParentOrderId, Offset: Offset, Limit: Limit, Sort: Sort, XShopperId: XShopperId, XAppKey: XAppKey), cancellationToken);
    }

    public async Task<GetAsyncResponse> GetAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/orders/{orderId}",
                new[]
            {
                new KeyValuePair<string, object?>("orderId", request.OrderId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
                new KeyValuePair<string, object?>("X-App-Key", request.XAppKey),
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

    public Task<GetAsyncResponse> GetAsync(string OrderId, string? XShopperId, string? XMarketId, string XAppKey, CancellationToken cancellationToken = default)
    {
        return GetAsync(new GetAsyncRequest(OrderId: OrderId, XShopperId: XShopperId, XMarketId: XMarketId, XAppKey: XAppKey), cancellationToken);
    }

    private OrdersApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new OrdersBadRequestException(exception),
            401 => new OrdersUnauthorizedException(exception),
            403 => new OrdersForbiddenException(exception),
            404 => new OrdersNotFoundException(exception),
            409 => new OrdersConflictException(exception),
            422 => new OrdersUnprocessableEntityException(exception),
            429 => new OrdersRateLimitException(exception),
            504 => new OrdersGatewayTimeoutException(exception),
            _ => new OrdersServerException(exception),
        };
    }
}
