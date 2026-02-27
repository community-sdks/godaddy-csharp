using System.Text.Json.Nodes;

namespace CommunitySdks.GoDaddy.Services;

public sealed class DomainsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public DomainsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public Task<JsonNode?> ListAsync(object? XShopperId, object? Statuses, object? StatusGroups, object? Limit, object? Marker, object? Includes, object? ModifiedDate, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("statuses", Statuses),
            new KeyValuePair<string, object?>("statusGroups", StatusGroups),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("marker", Marker),
            new KeyValuePair<string, object?>("includes", Includes),
            new KeyValuePair<string, object?>("modifiedDate", ModifiedDate),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAgreementAsync(object Tlds, object Privacy, object? XMarketId, object? ForTransfer, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/agreements",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("tlds", Tlds),
            new KeyValuePair<string, object?>("privacy", Privacy),
            new KeyValuePair<string, object?>("forTransfer", ForTransfer),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Market-Id", XMarketId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> AvailableAsync(object Domain, object? CheckType, object? ForTransfer, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/available",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("checkType", CheckType),
            new KeyValuePair<string, object?>("forTransfer", ForTransfer),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> AvailableBulkAsync(object Domains, object? CheckType, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/available",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("checkType", CheckType),
        },
            null,
            Domains,
            cancellationToken);
    }

    public Task<JsonNode?> ContactsValidateAsync(object Body, object? XPrivateLabelId, object? MarketId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/contacts/validate",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("marketId", MarketId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Private-Label-Id", XPrivateLabelId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PurchaseAsync(object Body, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/purchase",
            null,
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> SchemaAsync(object Tld, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/purchase/schema/{tld}",
            new[]
        {
            new KeyValuePair<string, object?>("tld", Tld),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> ValidateAsync(object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/purchase/validate",
            null,
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> SuggestAsync(object? XShopperId, object? Query, object? Country, object? City, object? Sources, object? Tlds, object? LengthMax, object? LengthMin, object? Limit, object? WaitMs, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/suggest",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("query", Query),
            new KeyValuePair<string, object?>("country", Country),
            new KeyValuePair<string, object?>("city", City),
            new KeyValuePair<string, object?>("sources", Sources),
            new KeyValuePair<string, object?>("tlds", Tlds),
            new KeyValuePair<string, object?>("lengthMax", LengthMax),
            new KeyValuePair<string, object?>("lengthMin", LengthMin),
            new KeyValuePair<string, object?>("limit", Limit),
            new KeyValuePair<string, object?>("waitMs", WaitMs),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> TldsAsync(CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/tlds",
            null,
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> CancelAsync(object Domain, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/domains/{domain}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetAsync(object Domain, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/{domain}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> UpdateAsync(object Domain, object Body, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v1/domains/{domain}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> UpdateContactsAsync(object Domain, object Contacts, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v1/domains/{domain}/contacts",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Contacts,
            cancellationToken);
    }

    public Task<JsonNode?> CancelPrivacyAsync(object Domain, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/domains/{domain}/privacy",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PurchasePrivacyAsync(object Domain, object Body, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/{domain}/privacy/purchase",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> RecordAddAsync(object Domain, object Records, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v1/domains/{domain}/records",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Records,
            cancellationToken);
    }

    public Task<JsonNode?> RecordReplaceAsync(object Domain, object Records, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v1/domains/{domain}/records",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Records,
            cancellationToken);
    }

    public Task<JsonNode?> RecordGetAsync(object Domain, object Type, object Name, object? XShopperId, object? Offset, object? Limit, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v1/domains/{domain}/records/{type}/{name}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("name", Name),
        },
            new[]
        {
            new KeyValuePair<string, object?>("offset", Offset),
            new KeyValuePair<string, object?>("limit", Limit),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> RecordReplaceTypeNameAsync(object Domain, object Type, object Name, object Records, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v1/domains/{domain}/records/{type}/{name}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("name", Name),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Records,
            cancellationToken);
    }

    public Task<JsonNode?> RecordDeleteTypeNameAsync(object Domain, object Type, object Name, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v1/domains/{domain}/records/{type}/{name}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
            new KeyValuePair<string, object?>("name", Name),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> RecordReplaceTypeAsync(object Domain, object Type, object Records, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v1/domains/{domain}/records/{type}",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Records,
            cancellationToken);
    }

    public Task<JsonNode?> RenewAsync(object Domain, object? XShopperId, object? Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/{domain}/renew",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> TransferInAsync(object Domain, object Body, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/{domain}/transfer",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> VerifyEmailAsync(object Domain, object? XShopperId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v1/domains/{domain}/verifyRegistrantEmail",
            new[]
        {
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Shopper-Id", XShopperId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainAsync(object CustomerId, object Domain, object? XRequestId, object? Includes, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            new[]
        {
            new KeyValuePair<string, object?>("includes", Includes),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v2/customers/{customerId}/domains/{domain}/changeOfRegistrant",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}/changeOfRegistrant",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v2/customers/{customerId}/domains/{domain}/dnssecRecords",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v2/customers/{customerId}/domains/{domain}/dnssecRecords",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PutV2CustomersCustomerIdDomainsDomainNameServersAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v2/customers/{customerId}/domains/{domain}/nameServers",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}/privacy/forwarding",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v2/customers/{customerId}/domains/{domain}/privacy/forwarding",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainRedeemAsync(object CustomerId, object Domain, object? XRequestId, object? Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/redeem",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainRenewAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/renew",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transfer",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainTransferAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}/transfer",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transfer/validate",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferInAccept",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferInCancel",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferInRestart",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferInRetry",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferOutAsync(object CustomerId, object Domain, object Registrar, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferOut",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            new[]
        {
            new KeyValuePair<string, object?>("registrar", Registrar),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferOutAccept",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync(object CustomerId, object Domain, object? XRequestId, object? Reason, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/transferOutReject",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            new[]
        {
            new KeyValuePair<string, object?>("reason", Reason),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DomainsForwardsDeleteAsync(object CustomerId, object Fqdn, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v2/customers/{customerId}/domains/forwards/{fqdn}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("fqdn", Fqdn),
        },
            null,
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DomainsForwardsGetAsync(object CustomerId, object Fqdn, object? IncludeSubs, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/forwards/{fqdn}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("fqdn", Fqdn),
        },
            new[]
        {
            new KeyValuePair<string, object?>("includeSubs", IncludeSubs),
        },
            null,
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DomainsForwardsPutAsync(object CustomerId, object Fqdn, object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v2/customers/{customerId}/domains/forwards/{fqdn}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("fqdn", Fqdn),
        },
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> DomainsForwardsPostAsync(object CustomerId, object Fqdn, object Body, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/forwards/{fqdn}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("fqdn", Fqdn),
        },
            null,
            null,
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainActionsAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}/actions",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync(object CustomerId, object Domain, object Type, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "DELETE",
            "/v2/customers/{customerId}/domains/{domain}/actions/{type}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync(object CustomerId, object Domain, object Type, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/{domain}/actions/{type}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
            new KeyValuePair<string, object?>("type", Type),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsNotificationsAsync(object CustomerId, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/notifications",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsNotificationsOptInAsync(object CustomerId, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/notifications/optIn",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PutV2CustomersCustomerIdDomainsNotificationsOptInAsync(object CustomerId, object Types, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PUT",
            "/v2/customers/{customerId}/domains/notifications/optIn",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            new[]
        {
            new KeyValuePair<string, object?>("types", Types),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync(object CustomerId, object Type, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/notifications/schemas/{type}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("type", Type),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync(object CustomerId, object NotificationId, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/notifications/{notificationId}/acknowledge",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("notificationId", NotificationId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsRegisterAsync(object CustomerId, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/register",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync(object CustomerId, object Tld, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/customers/{customerId}/domains/register/schema/{tld}",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("tld", Tld),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsRegisterValidateAsync(object CustomerId, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/register/validate",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2DomainsMaintenancesAsync(object? XRequestId, object? Status, object? ModifiedAtAfter, object? StartsAtAfter, object? Limit, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/domains/maintenances",
            null,
            new[]
        {
            new KeyValuePair<string, object?>("status", Status),
            new KeyValuePair<string, object?>("modifiedAtAfter", ModifiedAtAfter),
            new KeyValuePair<string, object?>("startsAtAfter", StartsAtAfter),
            new KeyValuePair<string, object?>("limit", Limit),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2DomainsMaintenancesMaintenanceIdAsync(object MaintenanceId, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/domains/maintenances/{maintenanceId}",
            new[]
        {
            new KeyValuePair<string, object?>("maintenanceId", MaintenanceId),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> GetV2DomainsUsageYyyymmAsync(object Yyyymm, object? XRequestId, object? Includes, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "GET",
            "/v2/domains/usage/{yyyymm}",
            new[]
        {
            new KeyValuePair<string, object?>("yyyymm", Yyyymm),
        },
            new[]
        {
            new KeyValuePair<string, object?>("includes", Includes),
        },
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }

    public Task<JsonNode?> PatchV2CustomersCustomerIdDomainsDomainContactsAsync(object CustomerId, object Domain, object Body, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "PATCH",
            "/v2/customers/{customerId}/domains/{domain}/contacts",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            Body,
            cancellationToken);
    }

    public Task<JsonNode?> PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync(object CustomerId, object Domain, object? XRequestId, CancellationToken cancellationToken = default)
    {
        return CallAsync(
            "POST",
            "/v2/customers/{customerId}/domains/{domain}/regenerateAuthCode",
            new[]
        {
            new KeyValuePair<string, object?>("customerId", CustomerId),
            new KeyValuePair<string, object?>("domain", Domain),
        },
            null,
            new[]
        {
            new KeyValuePair<string, object?>("X-Request-Id", XRequestId),
        },
            null,
            cancellationToken);
    }
}
