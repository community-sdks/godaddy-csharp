using CommunitySdks.GoDaddy.Dto.Shoppers.Requests;
using CommunitySdks.GoDaddy.Dto.Shoppers.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Shoppers;

namespace CommunitySdks.GoDaddy.Services;

public sealed class ShoppersService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public ShoppersService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<CreateSubaccountAsyncResponse> CreateSubaccountAsync(CreateSubaccountAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/shoppers/subaccount",
                null,
                null,
                null,
                request.Subaccount,
                cancellationToken).ConfigureAwait(false);

            return CreateSubaccountAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CreateSubaccountAsyncResponse> CreateSubaccountAsync(CreateSubaccountAsyncRequestSubaccount Subaccount, CancellationToken cancellationToken = default)
    {
        return CreateSubaccountAsync(new CreateSubaccountAsyncRequest(Subaccount: Subaccount), cancellationToken);
    }

    public async Task<GetAsyncResponse> GetAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/shoppers/{shopperId}",
                new[]
            {
                new KeyValuePair<string, object?>("shopperId", request.ShopperId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("includes", request.Includes),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAsyncResponse> GetAsync(string ShopperId, IReadOnlyList<string>? Includes, CancellationToken cancellationToken = default)
    {
        return GetAsync(new GetAsyncRequest(ShopperId: ShopperId, Includes: Includes), cancellationToken);
    }

    public async Task<UpdateAsyncResponse> UpdateAsync(UpdateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/shoppers/{shopperId}",
                new[]
            {
                new KeyValuePair<string, object?>("shopperId", request.ShopperId),
            },
                null,
                null,
                request.Shopper,
                cancellationToken).ConfigureAwait(false);

            return UpdateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<UpdateAsyncResponse> UpdateAsync(string ShopperId, UpdateAsyncRequestShopper Shopper, CancellationToken cancellationToken = default)
    {
        return UpdateAsync(new UpdateAsyncRequest(ShopperId: ShopperId, Shopper: Shopper), cancellationToken);
    }

    public async Task<DeleteAsyncResponse> DeleteAsync(DeleteAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/shoppers/{shopperId}",
                new[]
            {
                new KeyValuePair<string, object?>("shopperId", request.ShopperId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("auditClientIp", request.AuditClientIp),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return DeleteAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DeleteAsyncResponse> DeleteAsync(string ShopperId, string AuditClientIp, CancellationToken cancellationToken = default)
    {
        return DeleteAsync(new DeleteAsyncRequest(ShopperId: ShopperId, AuditClientIp: AuditClientIp), cancellationToken);
    }

    public async Task<GetStatusAsyncResponse> GetStatusAsync(GetStatusAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/shoppers/{shopperId}/status",
                new[]
            {
                new KeyValuePair<string, object?>("shopperId", request.ShopperId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("auditClientIp", request.AuditClientIp),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetStatusAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetStatusAsyncResponse> GetStatusAsync(string ShopperId, string AuditClientIp, CancellationToken cancellationToken = default)
    {
        return GetStatusAsync(new GetStatusAsyncRequest(ShopperId: ShopperId, AuditClientIp: AuditClientIp), cancellationToken);
    }

    public async Task<ChangePasswordAsyncResponse> ChangePasswordAsync(ChangePasswordAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v1/shoppers/{shopperId}/factors/password",
                new[]
            {
                new KeyValuePair<string, object?>("shopperId", request.ShopperId),
            },
                null,
                null,
                request.Secret,
                cancellationToken).ConfigureAwait(false);

            return ChangePasswordAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ChangePasswordAsyncResponse> ChangePasswordAsync(string ShopperId, ChangePasswordAsyncRequestSecret Secret, CancellationToken cancellationToken = default)
    {
        return ChangePasswordAsync(new ChangePasswordAsyncRequest(ShopperId: ShopperId, Secret: Secret), cancellationToken);
    }

    private ShoppersApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new ShoppersBadRequestException(exception),
            401 => new ShoppersUnauthorizedException(exception),
            403 => new ShoppersForbiddenException(exception),
            404 => new ShoppersNotFoundException(exception),
            409 => new ShoppersConflictException(exception),
            422 => new ShoppersUnprocessableEntityException(exception),
            429 => new ShoppersRateLimitException(exception),
            504 => new ShoppersGatewayTimeoutException(exception),
            _ => new ShoppersServerException(exception),
        };
    }
}
