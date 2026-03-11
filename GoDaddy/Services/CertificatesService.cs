using CommunitySdks.GoDaddy.Dto.Certificates.Requests;
using CommunitySdks.GoDaddy.Dto.Certificates.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Certificates;

namespace CommunitySdks.GoDaddy.Services;

public sealed class CertificatesService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public CertificatesService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<CertificateCreateAsyncResponse> CertificateCreateAsync(CertificateCreateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates",
                null,
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                request.CertificateCreate,
                cancellationToken).ConfigureAwait(false);

            return CertificateCreateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCreateAsyncResponse> CertificateCreateAsync(string? XMarketId, CertificateCreateAsyncRequestCertificateCreate CertificateCreate, CancellationToken cancellationToken = default)
    {
        return CertificateCreateAsync(new CertificateCreateAsyncRequest(XMarketId: XMarketId, CertificateCreate: CertificateCreate), cancellationToken);
    }

    public async Task<CertificateValidateAsyncResponse> CertificateValidateAsync(CertificateValidateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/validate",
                null,
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                request.CertificateCreate,
                cancellationToken).ConfigureAwait(false);

            return CertificateValidateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateValidateAsyncResponse> CertificateValidateAsync(string? XMarketId, CertificateValidateAsyncRequestCertificateCreate CertificateCreate, CancellationToken cancellationToken = default)
    {
        return CertificateValidateAsync(new CertificateValidateAsyncRequest(XMarketId: XMarketId, CertificateCreate: CertificateCreate), cancellationToken);
    }

    public async Task<CertificateGetAsyncResponse> CertificateGetAsync(CertificateGetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateGetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateGetAsyncResponse> CertificateGetAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateGetAsync(new CertificateGetAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateActionRetrieveAsyncResponse> CertificateActionRetrieveAsync(CertificateActionRetrieveAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}/actions",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateActionRetrieveAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateActionRetrieveAsyncResponse> CertificateActionRetrieveAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateActionRetrieveAsync(new CertificateActionRetrieveAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateResendEmailAsyncResponse> CertificateResendEmailAsync(CertificateResendEmailAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/email/{emailId}/resend",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
                new KeyValuePair<string, object?>("emailId", request.EmailId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateResendEmailAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateResendEmailAsyncResponse> CertificateResendEmailAsync(string CertificateId, string EmailId, CancellationToken cancellationToken = default)
    {
        return CertificateResendEmailAsync(new CertificateResendEmailAsyncRequest(CertificateId: CertificateId, EmailId: EmailId), cancellationToken);
    }

    public async Task<CertificateAlternateEmailAddressAsyncResponse> CertificateAlternateEmailAddressAsync(CertificateAlternateEmailAddressAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/email/resend/{emailAddress}",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
                new KeyValuePair<string, object?>("emailAddress", request.EmailAddress),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateAlternateEmailAddressAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateAlternateEmailAddressAsyncResponse> CertificateAlternateEmailAddressAsync(string CertificateId, string EmailAddress, CancellationToken cancellationToken = default)
    {
        return CertificateAlternateEmailAddressAsync(new CertificateAlternateEmailAddressAsyncRequest(CertificateId: CertificateId, EmailAddress: EmailAddress), cancellationToken);
    }

    public async Task<CertificateResendEmailAddressAsyncResponse> CertificateResendEmailAddressAsync(CertificateResendEmailAddressAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/email/{emailId}/resend/{emailAddress}",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
                new KeyValuePair<string, object?>("emailId", request.EmailId),
                new KeyValuePair<string, object?>("emailAddress", request.EmailAddress),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateResendEmailAddressAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateResendEmailAddressAsyncResponse> CertificateResendEmailAddressAsync(string CertificateId, string EmailId, string EmailAddress, CancellationToken cancellationToken = default)
    {
        return CertificateResendEmailAddressAsync(new CertificateResendEmailAddressAsyncRequest(CertificateId: CertificateId, EmailId: EmailId, EmailAddress: EmailAddress), cancellationToken);
    }

    public async Task<CertificateEmailHistoryAsyncResponse> CertificateEmailHistoryAsync(CertificateEmailHistoryAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}/email/history",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateEmailHistoryAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateEmailHistoryAsyncResponse> CertificateEmailHistoryAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateEmailHistoryAsync(new CertificateEmailHistoryAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateCallbackDeleteAsyncResponse> CertificateCallbackDeleteAsync(CertificateCallbackDeleteAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/certificates/{certificateId}/callback",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateCallbackDeleteAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCallbackDeleteAsyncResponse> CertificateCallbackDeleteAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateCallbackDeleteAsync(new CertificateCallbackDeleteAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateCallbackGetAsyncResponse> CertificateCallbackGetAsync(CertificateCallbackGetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}/callback",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateCallbackGetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCallbackGetAsyncResponse> CertificateCallbackGetAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateCallbackGetAsync(new CertificateCallbackGetAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateCallbackReplaceAsyncResponse> CertificateCallbackReplaceAsync(CertificateCallbackReplaceAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v1/certificates/{certificateId}/callback",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("callbackUrl", request.CallbackUrl),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateCallbackReplaceAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCallbackReplaceAsyncResponse> CertificateCallbackReplaceAsync(string CertificateId, string CallbackUrl, CancellationToken cancellationToken = default)
    {
        return CertificateCallbackReplaceAsync(new CertificateCallbackReplaceAsyncRequest(CertificateId: CertificateId, CallbackUrl: CallbackUrl), cancellationToken);
    }

    public async Task<CertificateCancelAsyncResponse> CertificateCancelAsync(CertificateCancelAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/cancel",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateCancelAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCancelAsyncResponse> CertificateCancelAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateCancelAsync(new CertificateCancelAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateDownloadAsyncResponse> CertificateDownloadAsync(CertificateDownloadAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}/download",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateDownloadAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateDownloadAsyncResponse> CertificateDownloadAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateDownloadAsync(new CertificateDownloadAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateReissueAsyncResponse> CertificateReissueAsync(CertificateReissueAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/reissue",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                request.ReissueCreate,
                cancellationToken).ConfigureAwait(false);

            return CertificateReissueAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateReissueAsyncResponse> CertificateReissueAsync(string CertificateId, CertificateReissueAsyncRequestReissueCreate ReissueCreate, CancellationToken cancellationToken = default)
    {
        return CertificateReissueAsync(new CertificateReissueAsyncRequest(CertificateId: CertificateId, ReissueCreate: ReissueCreate), cancellationToken);
    }

    public async Task<CertificateRenewAsyncResponse> CertificateRenewAsync(CertificateRenewAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/renew",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                request.RenewCreate,
                cancellationToken).ConfigureAwait(false);

            return CertificateRenewAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateRenewAsyncResponse> CertificateRenewAsync(string CertificateId, CertificateRenewAsyncRequestRenewCreate RenewCreate, CancellationToken cancellationToken = default)
    {
        return CertificateRenewAsync(new CertificateRenewAsyncRequest(CertificateId: CertificateId, RenewCreate: RenewCreate), cancellationToken);
    }

    public async Task<CertificateRevokeAsyncResponse> CertificateRevokeAsync(CertificateRevokeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/revoke",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                request.CertificateRevoke,
                cancellationToken).ConfigureAwait(false);

            return CertificateRevokeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateRevokeAsyncResponse> CertificateRevokeAsync(string CertificateId, CertificateRevokeAsyncRequestCertificateRevoke CertificateRevoke, CancellationToken cancellationToken = default)
    {
        return CertificateRevokeAsync(new CertificateRevokeAsyncRequest(CertificateId: CertificateId, CertificateRevoke: CertificateRevoke), cancellationToken);
    }

    public async Task<CertificateSitesealGetAsyncResponse> CertificateSitesealGetAsync(CertificateSitesealGetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/certificates/{certificateId}/siteSeal",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("theme", request.Theme),
                new KeyValuePair<string, object?>("locale", request.Locale),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateSitesealGetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateSitesealGetAsyncResponse> CertificateSitesealGetAsync(string CertificateId, string? Theme, string? Locale, CancellationToken cancellationToken = default)
    {
        return CertificateSitesealGetAsync(new CertificateSitesealGetAsyncRequest(CertificateId: CertificateId, Theme: Theme, Locale: Locale), cancellationToken);
    }

    public async Task<CertificateVerifydomaincontrolAsyncResponse> CertificateVerifydomaincontrolAsync(CertificateVerifydomaincontrolAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/certificates/{certificateId}/verifyDomainControl",
                new[]
            {
                new KeyValuePair<string, object?>("certificateId", request.CertificateId),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateVerifydomaincontrolAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateVerifydomaincontrolAsyncResponse> CertificateVerifydomaincontrolAsync(string CertificateId, CancellationToken cancellationToken = default)
    {
        return CertificateVerifydomaincontrolAsync(new CertificateVerifydomaincontrolAsyncRequest(CertificateId: CertificateId), cancellationToken);
    }

    public async Task<CertificateGetEntitlementAsyncResponse> CertificateGetEntitlementAsync(CertificateGetEntitlementAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/certificates",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("entitlementId", request.EntitlementId),
                new KeyValuePair<string, object?>("latest", request.Latest),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateGetEntitlementAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateGetEntitlementAsyncResponse> CertificateGetEntitlementAsync(string EntitlementId, bool? Latest, CancellationToken cancellationToken = default)
    {
        return CertificateGetEntitlementAsync(new CertificateGetEntitlementAsyncRequest(EntitlementId: EntitlementId, Latest: Latest), cancellationToken);
    }

    public async Task<CertificateCreateV2CertificatesAsyncResponse> CertificateCreateV2CertificatesAsync(CertificateCreateV2CertificatesAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/certificates",
                null,
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                request.SubscriptionCertificateCreate,
                cancellationToken).ConfigureAwait(false);

            return CertificateCreateV2CertificatesAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateCreateV2CertificatesAsyncResponse> CertificateCreateV2CertificatesAsync(string? XMarketId, CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreate SubscriptionCertificateCreate, CancellationToken cancellationToken = default)
    {
        return CertificateCreateV2CertificatesAsync(new CertificateCreateV2CertificatesAsyncRequest(XMarketId: XMarketId, SubscriptionCertificateCreate: SubscriptionCertificateCreate), cancellationToken);
    }

    public async Task<CertificateDownloadEntitlementAsyncResponse> CertificateDownloadEntitlementAsync(CertificateDownloadEntitlementAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/certificates/download",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("entitlementId", request.EntitlementId),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CertificateDownloadEntitlementAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CertificateDownloadEntitlementAsyncResponse> CertificateDownloadEntitlementAsync(string EntitlementId, CancellationToken cancellationToken = default)
    {
        return CertificateDownloadEntitlementAsync(new CertificateDownloadEntitlementAsyncRequest(EntitlementId: EntitlementId), cancellationToken);
    }

    public async Task<GetCustomerCertificatesByCustomerIdAsyncResponse> GetCustomerCertificatesByCustomerIdAsync(GetCustomerCertificatesByCustomerIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/certificates",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetCustomerCertificatesByCustomerIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetCustomerCertificatesByCustomerIdAsyncResponse> GetCustomerCertificatesByCustomerIdAsync(string? Param1, string? Param2, string? Param3, CancellationToken cancellationToken = default)
    {
        return GetCustomerCertificatesByCustomerIdAsync(new GetCustomerCertificatesByCustomerIdAsyncRequest(Param1: Param1, Param2: Param2, Param3: Param3), cancellationToken);
    }

    public async Task<GetCertificateDetailByCertIdentifierAsyncResponse> GetCertificateDetailByCertIdentifierAsync(GetCertificateDetailByCertIdentifierAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/certificates/{certificateId}",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetCertificateDetailByCertIdentifierAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetCertificateDetailByCertIdentifierAsyncResponse> GetCertificateDetailByCertIdentifierAsync(string? Param1, string? Param2, CancellationToken cancellationToken = default)
    {
        return GetCertificateDetailByCertIdentifierAsync(new GetCertificateDetailByCertIdentifierAsyncRequest(Param1: Param1, Param2: Param2), cancellationToken);
    }

    public async Task<GetDomainInformationByCertificateIdAsyncResponse> GetDomainInformationByCertificateIdAsync(GetDomainInformationByCertificateIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/certificates/{certificateId}/domainVerifications",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetDomainInformationByCertificateIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetDomainInformationByCertificateIdAsyncResponse> GetDomainInformationByCertificateIdAsync(string? Param1, string? Param2, CancellationToken cancellationToken = default)
    {
        return GetDomainInformationByCertificateIdAsync(new GetDomainInformationByCertificateIdAsyncRequest(Param1: Param1, Param2: Param2), cancellationToken);
    }

    public async Task<GetDomainDetailsByDomainAsyncResponse> GetDomainDetailsByDomainAsync(GetDomainDetailsByDomainAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/certificates/{certificateId}/domainVerifications/{domain}",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetDomainDetailsByDomainAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetDomainDetailsByDomainAsyncResponse> GetDomainDetailsByDomainAsync(string? Param1, string? Param2, string? Param3, CancellationToken cancellationToken = default)
    {
        return GetDomainDetailsByDomainAsync(new GetDomainDetailsByDomainAsyncRequest(Param1: Param1, Param2: Param2, Param3: Param3), cancellationToken);
    }

    public async Task<GetAcmeExternalAccountBindingAsyncResponse> GetAcmeExternalAccountBindingAsync(GetAcmeExternalAccountBindingAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/certificates/acme/externalAccountBinding",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAcmeExternalAccountBindingAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAcmeExternalAccountBindingAsyncResponse> GetAcmeExternalAccountBindingAsync(string? Param1, CancellationToken cancellationToken = default)
    {
        return GetAcmeExternalAccountBindingAsync(new GetAcmeExternalAccountBindingAsyncRequest(Param1: Param1), cancellationToken);
    }

    public async Task<RetrieveSslByDomainResellerAsyncResponse> RetrieveSslByDomainResellerAsync(RetrieveSslByDomainResellerAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/certificates/subscriptions/search",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return RetrieveSslByDomainResellerAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RetrieveSslByDomainResellerAsyncResponse> RetrieveSslByDomainResellerAsync(string? Param1, string? Param2, string? Param3, string? Param4, string? Param5, string? Param6, CancellationToken cancellationToken = default)
    {
        return RetrieveSslByDomainResellerAsync(new RetrieveSslByDomainResellerAsyncRequest(Param1: Param1, Param2: Param2, Param3: Param3, Param4: Param4, Param5: Param5, Param6: Param6), cancellationToken);
    }

    public async Task<RetrieveSslByDomainSubscriptionResellerAsyncResponse> RetrieveSslByDomainSubscriptionResellerAsync(RetrieveSslByDomainSubscriptionResellerAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/certificates/subscription/{guid}",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return RetrieveSslByDomainSubscriptionResellerAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RetrieveSslByDomainSubscriptionResellerAsyncResponse> RetrieveSslByDomainSubscriptionResellerAsync(string? Param1, string? Param2, string? Param3, string? Param4, string? Param5, string? Param6, string? Param7, CancellationToken cancellationToken = default)
    {
        return RetrieveSslByDomainSubscriptionResellerAsync(new RetrieveSslByDomainSubscriptionResellerAsyncRequest(Param1: Param1, Param2: Param2, Param3: Param3, Param4: Param4, Param5: Param5, Param6: Param6, Param7: Param7), cancellationToken);
    }

    private CertificatesApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new CertificatesBadRequestException(exception),
            401 => new CertificatesUnauthorizedException(exception),
            403 => new CertificatesForbiddenException(exception),
            404 => new CertificatesNotFoundException(exception),
            409 => new CertificatesConflictException(exception),
            422 => new CertificatesUnprocessableEntityException(exception),
            429 => new CertificatesRateLimitException(exception),
            504 => new CertificatesGatewayTimeoutException(exception),
            _ => new CertificatesServerException(exception),
        };
    }
}
