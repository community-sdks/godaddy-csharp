using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class CertificatesService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public CertificatesService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> CertificateCreateAsync(object CertificateCreate, object? XMarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates",
            null,
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            CertificateCreate,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateValidateAsync(object CertificateCreate, object? XMarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/validate",
            null,
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            CertificateCreate,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateGetAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateActionRetrieveAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}/actions",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateResendEmailAsync(object CertificateId, object EmailId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/email/{emailId}/resend",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
            new KeyValuePair<string, object?>("emailId", EmailId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateAlternateEmailAddressAsync(object CertificateId, object EmailAddress, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/email/resend/{emailAddress}",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
            new KeyValuePair<string, object?>("emailAddress", EmailAddress),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateResendEmailAddressAsync(object CertificateId, object EmailId, object EmailAddress, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/email/{emailId}/resend/{emailAddress}",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
            new KeyValuePair<string, object?>("emailId", EmailId),
            new KeyValuePair<string, object?>("emailAddress", EmailAddress),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateEmailHistoryAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}/email/history",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateCallbackDeleteAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/certificates/{certificateId}/callback",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateCallbackGetAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}/callback",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateCallbackReplaceAsync(object CertificateId, object CallbackUrl, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v1/certificates/{certificateId}/callback",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("callbackUrl", CallbackUrl),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateCancelAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/cancel",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateDownloadAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}/download",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateReissueAsync(object CertificateId, object ReissueCreate, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/reissue",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            ReissueCreate,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateRenewAsync(object CertificateId, object RenewCreate, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/renew",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            RenewCreate,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateRevokeAsync(object CertificateId, object CertificateRevoke, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/revoke",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            CertificateRevoke,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateSitesealGetAsync(object CertificateId, object? Theme, object? Locale, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/certificates/{certificateId}/siteSeal",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("theme", Theme),
            new KeyValuePair<string, object?>("locale", Locale),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateVerifydomaincontrolAsync(object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/certificates/{certificateId}/verifyDomainControl",
            new[]
        {
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateGetEntitlementAsync(object EntitlementId, object? Latest, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/certificates",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("entitlementId", EntitlementId),
            new KeyValuePair<string, object?>("latest", Latest),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateCreateV2Async(object SubscriptionCertificateCreate, object? XMarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/certificates",
            null,
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            SubscriptionCertificateCreate,
            cancellationToken);
    }

    public Task<JsonNode?> CertificateDownloadEntitlementAsync(object EntitlementId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/certificates/download",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("entitlementId", EntitlementId),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetCustomerCertificatesByCustomerIdAsync(object CustomerId, object? Offset, object? Limit, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/certificates",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("offset", Offset),
            new KeyValuePair<string, object?>("limit", Limit),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetCertificateDetailByCertIdentifierAsync(object CustomerId, object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/certificates/{certificateId}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetDomainInformationByCertificateIdAsync(object CustomerId, object CertificateId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/certificates/{certificateId}/domainVerifications",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("certificateId", CertificateId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetDomainDetailsByDomainAsync(object CustomerId, object CertificateId, object Domain, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/certificates/{certificateId}/domainVerifications/{domain}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("certificateId", CertificateId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAcmeExternalAccountBindingAsync(object CustomerId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/certificates/acme/externalAccountBinding",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> RetrieveSslByDomainResellerAsync(object? PageSize, object? Page, object? Domain, object? Status, object? Type, object? Validation, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/certificates/subscriptions/search",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("pageSize", PageSize),
            new KeyValuePair<string, object?>("page", Page),
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("status", Status),
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("validation", Validation),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> RetrieveSslByDomainSubscriptionResellerAsync(object Guid, object? PageSize, object? Page, object? Domain, object? Status, object? Type, object? Validation, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/certificates/subscription/{guid}",
            new[]
        {
            new KeyValuePair<string, object?>("guid", Guid),
        },
            new[]
        {
            new KeyValuePair<string, object?>("pageSize", PageSize),
            new KeyValuePair<string, object?>("page", Page),
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("status", Status),
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("validation", Validation),
        },
            null,
            null,
            cancellationToken);
    }
}
