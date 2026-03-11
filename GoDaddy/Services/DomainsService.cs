using CommunitySdks.GoDaddy.Dto.Domains.Requests;
using CommunitySdks.GoDaddy.Dto.Domains.Responses;
using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Errors.Domains;

namespace CommunitySdks.GoDaddy.Services;

public sealed class DomainsService : AbstractService
{
    public const string ServiceBaseUrl = "https://api.ote-godaddy.com";

    public DomainsService(ApiClient client) : base(client, ServiceBaseUrl)
    {
    }

    public async Task<ListAsyncResponse> ListAsync(ListAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("statuses", request.Statuses),
                new KeyValuePair<string, object?>("statusGroups", request.StatusGroups),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("marker", request.Marker),
                new KeyValuePair<string, object?>("includes", request.Includes),
                new KeyValuePair<string, object?>("modifiedDate", request.ModifiedDate),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
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

    public Task<ListAsyncResponse> ListAsync(string? XShopperId, IReadOnlyList<string>? Statuses, IReadOnlyList<string>? StatusGroups, int? Limit, string? Marker, IReadOnlyList<string>? Includes, string? ModifiedDate, CancellationToken cancellationToken = default)
    {
        return ListAsync(new ListAsyncRequest(XShopperId: XShopperId, Statuses: Statuses, StatusGroups: StatusGroups, Limit: Limit, Marker: Marker, Includes: Includes, ModifiedDate: ModifiedDate), cancellationToken);
    }

    public async Task<GetAgreementAsyncResponse> GetAgreementAsync(GetAgreementAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/agreements",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("tlds", request.Tlds),
                new KeyValuePair<string, object?>("privacy", request.Privacy),
                new KeyValuePair<string, object?>("forTransfer", request.ForTransfer),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Market-Id", request.XMarketId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetAgreementAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetAgreementAsyncResponse> GetAgreementAsync(string? XMarketId, IReadOnlyList<string> Tlds, bool Privacy, bool? ForTransfer, CancellationToken cancellationToken = default)
    {
        return GetAgreementAsync(new GetAgreementAsyncRequest(XMarketId: XMarketId, Tlds: Tlds, Privacy: Privacy, ForTransfer: ForTransfer), cancellationToken);
    }

    public async Task<AvailableAsyncResponse> AvailableAsync(AvailableAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/available",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("checkType", request.CheckType),
                new KeyValuePair<string, object?>("forTransfer", request.ForTransfer),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return AvailableAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<AvailableAsyncResponse> AvailableAsync(string Domain, string? CheckType, bool? ForTransfer, CancellationToken cancellationToken = default)
    {
        return AvailableAsync(new AvailableAsyncRequest(Domain: Domain, CheckType: CheckType, ForTransfer: ForTransfer), cancellationToken);
    }

    public async Task<AvailableBulkAsyncResponse> AvailableBulkAsync(AvailableBulkAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/available",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("checkType", request.CheckType),
            },
                null,
                request.Domains,
                cancellationToken).ConfigureAwait(false);

            return AvailableBulkAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<AvailableBulkAsyncResponse> AvailableBulkAsync(AvailableBulkAsyncRequestDomains Domains, string? CheckType, CancellationToken cancellationToken = default)
    {
        return AvailableBulkAsync(new AvailableBulkAsyncRequest(Domains: Domains, CheckType: CheckType), cancellationToken);
    }

    public async Task<ContactsValidateAsyncResponse> ContactsValidateAsync(ContactsValidateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/contacts/validate",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("marketId", request.MarketId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Private-Label-Id", request.XPrivateLabelId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return ContactsValidateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ContactsValidateAsyncResponse> ContactsValidateAsync(int? XPrivateLabelId, string? MarketId, ContactsValidateAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return ContactsValidateAsync(new ContactsValidateAsyncRequest(XPrivateLabelId: XPrivateLabelId, MarketId: MarketId, Body: Body), cancellationToken);
    }

    public async Task<PurchaseAsyncResponse> PurchaseAsync(PurchaseAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/purchase",
                null,
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PurchaseAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PurchaseAsyncResponse> PurchaseAsync(string? XShopperId, PurchaseAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PurchaseAsync(new PurchaseAsyncRequest(XShopperId: XShopperId, Body: Body), cancellationToken);
    }

    public async Task<SchemaAsyncResponse> SchemaAsync(SchemaAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/purchase/schema/{tld}",
                new[]
            {
                new KeyValuePair<string, object?>("tld", request.Tld),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return SchemaAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<SchemaAsyncResponse> SchemaAsync(string Tld, CancellationToken cancellationToken = default)
    {
        return SchemaAsync(new SchemaAsyncRequest(Tld: Tld), cancellationToken);
    }

    public async Task<ValidateAsyncResponse> ValidateAsync(ValidateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/purchase/validate",
                null,
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return ValidateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<ValidateAsyncResponse> ValidateAsync(ValidateAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return ValidateAsync(new ValidateAsyncRequest(Body: Body), cancellationToken);
    }

    public async Task<SuggestAsyncResponse> SuggestAsync(SuggestAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/suggest",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("query", request.Query),
                new KeyValuePair<string, object?>("country", request.Country),
                new KeyValuePair<string, object?>("city", request.City),
                new KeyValuePair<string, object?>("sources", request.Sources),
                new KeyValuePair<string, object?>("tlds", request.Tlds),
                new KeyValuePair<string, object?>("lengthMax", request.LengthMax),
                new KeyValuePair<string, object?>("lengthMin", request.LengthMin),
                new KeyValuePair<string, object?>("limit", request.Limit),
                new KeyValuePair<string, object?>("waitMs", request.WaitMs),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return SuggestAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<SuggestAsyncResponse> SuggestAsync(string? XShopperId, string? Query, string? Country, string? City, IReadOnlyList<string>? Sources, IReadOnlyList<string>? Tlds, int? LengthMax, int? LengthMin, int? Limit, int? WaitMs, CancellationToken cancellationToken = default)
    {
        return SuggestAsync(new SuggestAsyncRequest(XShopperId: XShopperId, Query: Query, Country: Country, City: City, Sources: Sources, Tlds: Tlds, LengthMax: LengthMax, LengthMin: LengthMin, Limit: Limit, WaitMs: WaitMs), cancellationToken);
    }

    public async Task<TldsAsyncResponse> TldsAsync(TldsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/tlds",
                null,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return TldsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<TldsAsyncResponse> TldsAsync(CancellationToken cancellationToken = default)
    {
        return TldsAsync(new TldsAsyncRequest(), cancellationToken);
    }

    public async Task<CancelAsyncResponse> CancelAsync(CancelAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/domains/{domain}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return CancelAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CancelAsyncResponse> CancelAsync(string Domain, CancellationToken cancellationToken = default)
    {
        return CancelAsync(new CancelAsyncRequest(Domain: Domain), cancellationToken);
    }

    public async Task<GetAsyncResponse> GetAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/{domain}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
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

    public Task<GetAsyncResponse> GetAsync(string? XShopperId, string Domain, CancellationToken cancellationToken = default)
    {
        return GetAsync(new GetAsyncRequest(XShopperId: XShopperId, Domain: Domain), cancellationToken);
    }

    public async Task<UpdateAsyncResponse> UpdateAsync(UpdateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v1/domains/{domain}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return UpdateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<UpdateAsyncResponse> UpdateAsync(string Domain, string? XShopperId, UpdateAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return UpdateAsync(new UpdateAsyncRequest(Domain: Domain, XShopperId: XShopperId, Body: Body), cancellationToken);
    }

    public async Task<UpdateContactsAsyncResponse> UpdateContactsAsync(UpdateContactsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v1/domains/{domain}/contacts",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Contacts,
                cancellationToken).ConfigureAwait(false);

            return UpdateContactsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<UpdateContactsAsyncResponse> UpdateContactsAsync(string? XShopperId, string Domain, UpdateContactsAsyncRequestContacts Contacts, CancellationToken cancellationToken = default)
    {
        return UpdateContactsAsync(new UpdateContactsAsyncRequest(XShopperId: XShopperId, Domain: Domain, Contacts: Contacts), cancellationToken);
    }

    public async Task<CancelPrivacyAsyncResponse> CancelPrivacyAsync(CancelPrivacyAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/domains/{domain}/privacy",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return CancelPrivacyAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<CancelPrivacyAsyncResponse> CancelPrivacyAsync(string? XShopperId, string Domain, CancellationToken cancellationToken = default)
    {
        return CancelPrivacyAsync(new CancelPrivacyAsyncRequest(XShopperId: XShopperId, Domain: Domain), cancellationToken);
    }

    public async Task<PurchasePrivacyAsyncResponse> PurchasePrivacyAsync(PurchasePrivacyAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/{domain}/privacy/purchase",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PurchasePrivacyAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PurchasePrivacyAsyncResponse> PurchasePrivacyAsync(string? XShopperId, string Domain, PurchasePrivacyAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PurchasePrivacyAsync(new PurchasePrivacyAsyncRequest(XShopperId: XShopperId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<RecordAddAsyncResponse> RecordAddAsync(RecordAddAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v1/domains/{domain}/records",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Records,
                cancellationToken).ConfigureAwait(false);

            return RecordAddAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordAddAsyncResponse> RecordAddAsync(string? XShopperId, string Domain, RecordAddAsyncRequestRecords Records, CancellationToken cancellationToken = default)
    {
        return RecordAddAsync(new RecordAddAsyncRequest(XShopperId: XShopperId, Domain: Domain, Records: Records), cancellationToken);
    }

    public async Task<RecordReplaceAsyncResponse> RecordReplaceAsync(RecordReplaceAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v1/domains/{domain}/records",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Records,
                cancellationToken).ConfigureAwait(false);

            return RecordReplaceAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordReplaceAsyncResponse> RecordReplaceAsync(string? XShopperId, string Domain, RecordReplaceAsyncRequestRecords Records, CancellationToken cancellationToken = default)
    {
        return RecordReplaceAsync(new RecordReplaceAsyncRequest(XShopperId: XShopperId, Domain: Domain, Records: Records), cancellationToken);
    }

    public async Task<RecordGetAsyncResponse> RecordGetAsync(RecordGetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v1/domains/{domain}/records/{type}/{name}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
                new KeyValuePair<string, object?>("name", request.Name),
            },
                new[]
            {
                new KeyValuePair<string, object?>("offset", request.Offset),
                new KeyValuePair<string, object?>("limit", request.Limit),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return RecordGetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordGetAsyncResponse> RecordGetAsync(string? XShopperId, string Domain, string Type, string Name, int? Offset, int? Limit, CancellationToken cancellationToken = default)
    {
        return RecordGetAsync(new RecordGetAsyncRequest(XShopperId: XShopperId, Domain: Domain, Type: Type, Name: Name, Offset: Offset, Limit: Limit), cancellationToken);
    }

    public async Task<RecordReplaceTypeNameAsyncResponse> RecordReplaceTypeNameAsync(RecordReplaceTypeNameAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v1/domains/{domain}/records/{type}/{name}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
                new KeyValuePair<string, object?>("name", request.Name),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Records,
                cancellationToken).ConfigureAwait(false);

            return RecordReplaceTypeNameAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordReplaceTypeNameAsyncResponse> RecordReplaceTypeNameAsync(string? XShopperId, string Domain, string Type, string Name, RecordReplaceTypeNameAsyncRequestRecords Records, CancellationToken cancellationToken = default)
    {
        return RecordReplaceTypeNameAsync(new RecordReplaceTypeNameAsyncRequest(XShopperId: XShopperId, Domain: Domain, Type: Type, Name: Name, Records: Records), cancellationToken);
    }

    public async Task<RecordDeleteTypeNameAsyncResponse> RecordDeleteTypeNameAsync(RecordDeleteTypeNameAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v1/domains/{domain}/records/{type}/{name}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
                new KeyValuePair<string, object?>("name", request.Name),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return RecordDeleteTypeNameAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordDeleteTypeNameAsyncResponse> RecordDeleteTypeNameAsync(string? XShopperId, string Domain, string Type, string Name, CancellationToken cancellationToken = default)
    {
        return RecordDeleteTypeNameAsync(new RecordDeleteTypeNameAsyncRequest(XShopperId: XShopperId, Domain: Domain, Type: Type, Name: Name), cancellationToken);
    }

    public async Task<RecordReplaceTypeAsyncResponse> RecordReplaceTypeAsync(RecordReplaceTypeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v1/domains/{domain}/records/{type}",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Records,
                cancellationToken).ConfigureAwait(false);

            return RecordReplaceTypeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RecordReplaceTypeAsyncResponse> RecordReplaceTypeAsync(string? XShopperId, string Domain, string Type, RecordReplaceTypeAsyncRequestRecords Records, CancellationToken cancellationToken = default)
    {
        return RecordReplaceTypeAsync(new RecordReplaceTypeAsyncRequest(XShopperId: XShopperId, Domain: Domain, Type: Type, Records: Records), cancellationToken);
    }

    public async Task<RenewAsyncResponse> RenewAsync(RenewAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/{domain}/renew",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return RenewAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<RenewAsyncResponse> RenewAsync(string? XShopperId, string Domain, RenewAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return RenewAsync(new RenewAsyncRequest(XShopperId: XShopperId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<TransferInAsyncResponse> TransferInAsync(TransferInAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/{domain}/transfer",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return TransferInAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<TransferInAsyncResponse> TransferInAsync(string? XShopperId, string Domain, TransferInAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return TransferInAsync(new TransferInAsyncRequest(XShopperId: XShopperId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<VerifyEmailAsyncResponse> VerifyEmailAsync(VerifyEmailAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v1/domains/{domain}/verifyRegistrantEmail",
                new[]
            {
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Shopper-Id", request.XShopperId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return VerifyEmailAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<VerifyEmailAsyncResponse> VerifyEmailAsync(string? XShopperId, string Domain, CancellationToken cancellationToken = default)
    {
        return VerifyEmailAsync(new VerifyEmailAsyncRequest(XShopperId: XShopperId, Domain: Domain), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainAsyncResponse> GetV2CustomersCustomerIdDomainsDomainAsync(GetV2CustomersCustomerIdDomainsDomainAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                new[]
            {
                new KeyValuePair<string, object?>("includes", request.Includes),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainAsyncResponse> GetV2CustomersCustomerIdDomainsDomainAsync(string? XRequestId, string CustomerId, string Domain, IReadOnlyList<string>? Includes, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainAsync(new GetV2CustomersCustomerIdDomainsDomainAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Includes: Includes), cancellationToken);
    }

    public async Task<DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v2/customers/{customerId}/domains/{domain}/changeOfRegistrant",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(new DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse> GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}/changeOfRegistrant",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncResponse> GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(new GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v2/customers/{customerId}/domains/{domain}/dnssecRecords",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(string? XRequestId, string CustomerId, string Domain, PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(new PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v2/customers/{customerId}/domains/{domain}/dnssecRecords",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(string? XRequestId, string CustomerId, string Domain, DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(new DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PutV2CustomersCustomerIdDomainsDomainNameServersAsyncResponse> PutV2CustomersCustomerIdDomainsDomainNameServersAsync(PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v2/customers/{customerId}/domains/{domain}/nameServers",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PutV2CustomersCustomerIdDomainsDomainNameServersAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PutV2CustomersCustomerIdDomainsDomainNameServersAsyncResponse> PutV2CustomersCustomerIdDomainsDomainNameServersAsync(string? XRequestId, string CustomerId, string Domain, PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PutV2CustomersCustomerIdDomainsDomainNameServersAsync(new PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse> GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}/privacy/forwarding",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse> GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(new GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v2/customers/{customerId}/domains/{domain}/privacy/forwarding",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(string? XRequestId, string CustomerId, string Domain, PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(new PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainRedeemAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRedeemAsync(PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/redeem",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainRedeemAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainRedeemAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRedeemAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainRedeemAsync(new PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainRenewAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRenewAsync(PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/renew",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainRenewAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainRenewAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRenewAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainRenewAsync(new PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferAsync(PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transfer",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferAsync(new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainTransferAsyncResponse> GetV2CustomersCustomerIdDomainsDomainTransferAsync(GetV2CustomersCustomerIdDomainsDomainTransferAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}/transfer",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainTransferAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainTransferAsyncResponse> GetV2CustomersCustomerIdDomainsDomainTransferAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainTransferAsync(new GetV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync(PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transfer/validate",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync(new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync(PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferInAccept",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync(new PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync(PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferInCancel",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync(new PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync(PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferInRestart",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync(new PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync(PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferInRetry",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync(string? XRequestId, string CustomerId, string Domain, PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync(new PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutAsync(PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferOut",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                new[]
            {
                new KeyValuePair<string, object?>("registrar", request.Registrar),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutAsync(string? XRequestId, string CustomerId, string Domain, string Registrar, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferOutAsync(new PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Registrar: Registrar), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync(PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferOutAccept",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync(new PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync(PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/transferOutReject",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                new[]
            {
                new KeyValuePair<string, object?>("reason", request.Reason),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncResponse> PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync(string? XRequestId, string CustomerId, string Domain, string? Reason, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync(new PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Reason: Reason), cancellationToken);
    }

    public async Task<DomainsForwardsDeleteAsyncResponse> DomainsForwardsDeleteAsync(DomainsForwardsDeleteAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v2/customers/{customerId}/domains/forwards/{fqdn}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("fqdn", request.Fqdn),
            },
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return DomainsForwardsDeleteAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DomainsForwardsDeleteAsyncResponse> DomainsForwardsDeleteAsync(string CustomerId, string Fqdn, CancellationToken cancellationToken = default)
    {
        return DomainsForwardsDeleteAsync(new DomainsForwardsDeleteAsyncRequest(CustomerId: CustomerId, Fqdn: Fqdn), cancellationToken);
    }

    public async Task<DomainsForwardsGetAsyncResponse> DomainsForwardsGetAsync(DomainsForwardsGetAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/forwards/{fqdn}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("fqdn", request.Fqdn),
            },
                new[]
            {
                new KeyValuePair<string, object?>("includeSubs", request.IncludeSubs),
            },
                null,
                null,
                cancellationToken).ConfigureAwait(false);

            return DomainsForwardsGetAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DomainsForwardsGetAsyncResponse> DomainsForwardsGetAsync(string CustomerId, string Fqdn, bool? IncludeSubs, CancellationToken cancellationToken = default)
    {
        return DomainsForwardsGetAsync(new DomainsForwardsGetAsyncRequest(CustomerId: CustomerId, Fqdn: Fqdn, IncludeSubs: IncludeSubs), cancellationToken);
    }

    public async Task<DomainsForwardsPutAsyncResponse> DomainsForwardsPutAsync(DomainsForwardsPutAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v2/customers/{customerId}/domains/forwards/{fqdn}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("fqdn", request.Fqdn),
            },
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return DomainsForwardsPutAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DomainsForwardsPutAsyncResponse> DomainsForwardsPutAsync(string CustomerId, string Fqdn, DomainsForwardsPutAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return DomainsForwardsPutAsync(new DomainsForwardsPutAsyncRequest(CustomerId: CustomerId, Fqdn: Fqdn, Body: Body), cancellationToken);
    }

    public async Task<DomainsForwardsPostAsyncResponse> DomainsForwardsPostAsync(DomainsForwardsPostAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/forwards/{fqdn}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("fqdn", request.Fqdn),
            },
                null,
                null,
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return DomainsForwardsPostAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DomainsForwardsPostAsyncResponse> DomainsForwardsPostAsync(string CustomerId, string Fqdn, DomainsForwardsPostAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return DomainsForwardsPostAsync(new DomainsForwardsPostAsyncRequest(CustomerId: CustomerId, Fqdn: Fqdn, Body: Body), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainActionsAsyncResponse> GetV2CustomersCustomerIdDomainsDomainActionsAsync(GetV2CustomersCustomerIdDomainsDomainActionsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}/actions",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainActionsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainActionsAsyncResponse> GetV2CustomersCustomerIdDomainsDomainActionsAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainActionsAsync(new GetV2CustomersCustomerIdDomainsDomainActionsAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    public async Task<DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync(DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "DELETE",
                "/v2/customers/{customerId}/domains/{domain}/actions/{type}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse> DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync(string? XRequestId, string CustomerId, string Domain, string Type, CancellationToken cancellationToken = default)
    {
        return DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync(new DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Type: Type), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse> GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync(GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/{domain}/actions/{type}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
                new KeyValuePair<string, object?>("type", request.Type),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncResponse> GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync(string? XRequestId, string CustomerId, string Domain, string Type, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync(new GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Type: Type), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsNotificationsAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsAsync(GetV2CustomersCustomerIdDomainsNotificationsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/notifications",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsNotificationsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsNotificationsAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsAsync(string? XRequestId, string CustomerId, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsNotificationsAsync(new GetV2CustomersCustomerIdDomainsNotificationsAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsOptInAsync(GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/notifications/optIn",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsOptInAsync(string? XRequestId, string CustomerId, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsNotificationsOptInAsync(new GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId), cancellationToken);
    }

    public async Task<PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse> PutV2CustomersCustomerIdDomainsNotificationsOptInAsync(PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PUT",
                "/v2/customers/{customerId}/domains/notifications/optIn",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                new[]
            {
                new KeyValuePair<string, object?>("types", request.Types),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncResponse> PutV2CustomersCustomerIdDomainsNotificationsOptInAsync(string? XRequestId, string CustomerId, IReadOnlyList<string> Types, CancellationToken cancellationToken = default)
    {
        return PutV2CustomersCustomerIdDomainsNotificationsOptInAsync(new PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Types: Types), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync(GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/notifications/schemas/{type}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("type", request.Type),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncResponse> GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync(string? XRequestId, string CustomerId, string Type, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync(new GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Type: Type), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncResponse> PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync(PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/notifications/{notificationId}/acknowledge",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("notificationId", request.NotificationId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncResponse> PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync(string? XRequestId, string CustomerId, string NotificationId, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync(new PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, NotificationId: NotificationId), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsRegisterAsyncResponse> PostV2CustomersCustomerIdDomainsRegisterAsync(PostV2CustomersCustomerIdDomainsRegisterAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/register",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsRegisterAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsRegisterAsyncResponse> PostV2CustomersCustomerIdDomainsRegisterAsync(string? XRequestId, string CustomerId, PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsRegisterAsync(new PostV2CustomersCustomerIdDomainsRegisterAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Body: Body), cancellationToken);
    }

    public async Task<GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncResponse> GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync(GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/customers/{customerId}/domains/register/schema/{tld}",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("tld", request.Tld),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncResponse> GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync(string? XRequestId, string CustomerId, string Tld, CancellationToken cancellationToken = default)
    {
        return GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync(new GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Tld: Tld), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsRegisterValidateAsyncResponse> PostV2CustomersCustomerIdDomainsRegisterValidateAsync(PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/register/validate",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsRegisterValidateAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsRegisterValidateAsyncResponse> PostV2CustomersCustomerIdDomainsRegisterValidateAsync(string? XRequestId, string CustomerId, PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsRegisterValidateAsync(new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Body: Body), cancellationToken);
    }

    public async Task<GetV2DomainsMaintenancesAsyncResponse> GetV2DomainsMaintenancesAsync(GetV2DomainsMaintenancesAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/domains/maintenances",
                null,
                new[]
            {
                new KeyValuePair<string, object?>("status", request.Status),
                new KeyValuePair<string, object?>("modifiedAtAfter", request.ModifiedAtAfter),
                new KeyValuePair<string, object?>("startsAtAfter", request.StartsAtAfter),
                new KeyValuePair<string, object?>("limit", request.Limit),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2DomainsMaintenancesAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2DomainsMaintenancesAsyncResponse> GetV2DomainsMaintenancesAsync(string? XRequestId, string? Status, string? ModifiedAtAfter, string? StartsAtAfter, int? Limit, CancellationToken cancellationToken = default)
    {
        return GetV2DomainsMaintenancesAsync(new GetV2DomainsMaintenancesAsyncRequest(XRequestId: XRequestId, Status: Status, ModifiedAtAfter: ModifiedAtAfter, StartsAtAfter: StartsAtAfter, Limit: Limit), cancellationToken);
    }

    public async Task<GetV2DomainsMaintenancesMaintenanceIdAsyncResponse> GetV2DomainsMaintenancesMaintenanceIdAsync(GetV2DomainsMaintenancesMaintenanceIdAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/domains/maintenances/{maintenanceId}",
                new[]
            {
                new KeyValuePair<string, object?>("maintenanceId", request.MaintenanceId),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2DomainsMaintenancesMaintenanceIdAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2DomainsMaintenancesMaintenanceIdAsyncResponse> GetV2DomainsMaintenancesMaintenanceIdAsync(string? XRequestId, string MaintenanceId, CancellationToken cancellationToken = default)
    {
        return GetV2DomainsMaintenancesMaintenanceIdAsync(new GetV2DomainsMaintenancesMaintenanceIdAsyncRequest(XRequestId: XRequestId, MaintenanceId: MaintenanceId), cancellationToken);
    }

    public async Task<GetV2DomainsUsageYyyymmAsyncResponse> GetV2DomainsUsageYyyymmAsync(GetV2DomainsUsageYyyymmAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "GET",
                "/v2/domains/usage/{yyyymm}",
                new[]
            {
                new KeyValuePair<string, object?>("yyyymm", request.Yyyymm),
            },
                new[]
            {
                new KeyValuePair<string, object?>("includes", request.Includes),
            },
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return GetV2DomainsUsageYyyymmAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<GetV2DomainsUsageYyyymmAsyncResponse> GetV2DomainsUsageYyyymmAsync(string? XRequestId, string Yyyymm, IReadOnlyList<string>? Includes, CancellationToken cancellationToken = default)
    {
        return GetV2DomainsUsageYyyymmAsync(new GetV2DomainsUsageYyyymmAsyncRequest(XRequestId: XRequestId, Yyyymm: Yyyymm, Includes: Includes), cancellationToken);
    }

    public async Task<PatchV2CustomersCustomerIdDomainsDomainContactsAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainContactsAsync(PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "PATCH",
                "/v2/customers/{customerId}/domains/{domain}/contacts",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                request.Body,
                cancellationToken).ConfigureAwait(false);

            return PatchV2CustomersCustomerIdDomainsDomainContactsAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PatchV2CustomersCustomerIdDomainsDomainContactsAsyncResponse> PatchV2CustomersCustomerIdDomainsDomainContactsAsync(string? XRequestId, string CustomerId, string Domain, PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody Body, CancellationToken cancellationToken = default)
    {
        return PatchV2CustomersCustomerIdDomainsDomainContactsAsync(new PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain, Body: Body), cancellationToken);
    }

    public async Task<PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync(PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await CallAsync(
                "POST",
                "/v2/customers/{customerId}/domains/{domain}/regenerateAuthCode",
                new[]
            {
                new KeyValuePair<string, object?>("customerId", request.CustomerId),
                new KeyValuePair<string, object?>("domain", request.Domain),
            },
                null,
                new[]
            {
                new KeyValuePair<string, object?>("X-Request-Id", request.XRequestId),
            },
                null,
                cancellationToken).ConfigureAwait(false);

            return PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncResponse.FromJson(response);
        }
        catch (ApiException exception)
        {
            throw MapException(exception);
        }
    }

    public Task<PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncResponse> PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync(string? XRequestId, string CustomerId, string Domain, CancellationToken cancellationToken = default)
    {
        return PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync(new PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncRequest(XRequestId: XRequestId, CustomerId: CustomerId, Domain: Domain), cancellationToken);
    }

    private DomainsApiException MapException(ApiException exception)
    {
        return exception.StatusCode switch
        {
            400 => new DomainsBadRequestException(exception),
            401 => new DomainsUnauthorizedException(exception),
            403 => new DomainsForbiddenException(exception),
            404 => new DomainsNotFoundException(exception),
            409 => new DomainsConflictException(exception),
            422 => new DomainsUnprocessableEntityException(exception),
            429 => new DomainsRateLimitException(exception),
            504 => new DomainsGatewayTimeoutException(exception),
            _ => new DomainsServerException(exception),
        };
    }
}
