# DomainsService

Domain availability, purchase, management, transfer, and DNS endpoints.

## Accessor

```csharp
var service = client.Domains();
```

## Endpoints

### ListAsync

Calls `GET /v1/domains`.

```csharp
var response = await client.Domains().ListAsync("header-value", new[] { "sample" }, new[] { "sample" }, 1, "sample", new[] { "sample" }, "sample");
```

```json
{}
```

### GetAgreementAsync

Calls `GET /v1/domains/agreements`.

```csharp
var response = await client.Domains().GetAgreementAsync(new[] { "sample" }, true, "header-value", true);
```

```json
{}
```

### AvailableAsync

Calls `GET /v1/domains/available`.

```csharp
var response = await client.Domains().AvailableAsync("sample", "sample", true);
```

```json
{}
```

### AvailableBulkAsync

Calls `POST /v1/domains/available`.

```csharp
var response = await client.Domains().AvailableBulkAsync(new[] { "sample" }, "sample");
```

```json
{}
```

### ContactsValidateAsync

Calls `POST /v1/domains/contacts/validate`.

```csharp
var response = await client.Domains().ContactsValidateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "sample");
```

```json
{}
```

### PurchaseAsync

Calls `POST /v1/domains/purchase`.

```csharp
var response = await client.Domains().PurchaseAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### SchemaAsync

Calls `GET /v1/domains/purchase/schema/{tld}`.

```csharp
var response = await client.Domains().SchemaAsync("sample");
```

```json
{}
```

### ValidateAsync

Calls `POST /v1/domains/purchase/validate`.

```csharp
var response = await client.Domains().ValidateAsync(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### SuggestAsync

Calls `GET /v1/domains/suggest`.

```csharp
var response = await client.Domains().SuggestAsync("header-value", "sample", "sample", "sample", new[] { "sample" }, new[] { "sample" }, 1, 1, 1, 1);
```

```json
{}
```

### TldsAsync

Calls `GET /v1/domains/tlds`.

```csharp
var response = await client.Domains().TldsAsync();
```

```json
{}
```

### CancelAsync

Calls `DELETE /v1/domains/{domain}`.

```csharp
var response = await client.Domains().CancelAsync("sample");
```

```json
{}
```

### GetAsync

Calls `GET /v1/domains/{domain}`.

```csharp
var response = await client.Domains().GetAsync("sample", "header-value");
```

```json
{}
```

### UpdateAsync

Calls `PATCH /v1/domains/{domain}`.

```csharp
var response = await client.Domains().UpdateAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### UpdateContactsAsync

Calls `PATCH /v1/domains/{domain}/contacts`.

```csharp
var response = await client.Domains().UpdateContactsAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### CancelPrivacyAsync

Calls `DELETE /v1/domains/{domain}/privacy`.

```csharp
var response = await client.Domains().CancelPrivacyAsync("sample", "header-value");
```

```json
{}
```

### PurchasePrivacyAsync

Calls `POST /v1/domains/{domain}/privacy/purchase`.

```csharp
var response = await client.Domains().PurchasePrivacyAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### RecordAddAsync

Calls `PATCH /v1/domains/{domain}/records`.

```csharp
var response = await client.Domains().RecordAddAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### RecordReplaceAsync

Calls `PUT /v1/domains/{domain}/records`.

```csharp
var response = await client.Domains().RecordReplaceAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### RecordGetAsync

Calls `GET /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordGetAsync("sample", "sample", "sample", "header-value", 1, 1);
```

```json
{}
```

### RecordReplaceTypeNameAsync

Calls `PUT /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordReplaceTypeNameAsync("sample", "sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### RecordDeleteTypeNameAsync

Calls `DELETE /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordDeleteTypeNameAsync("sample", "sample", "sample", "header-value");
```

```json
{}
```

### RecordReplaceTypeAsync

Calls `PUT /v1/domains/{domain}/records/{type}`.

```csharp
var response = await client.Domains().RecordReplaceTypeAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### RenewAsync

Calls `POST /v1/domains/{domain}/renew`.

```csharp
var response = await client.Domains().RenewAsync("sample", "header-value", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### TransferInAsync

Calls `POST /v1/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().TransferInAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### VerifyEmailAsync

Calls `POST /v1/domains/{domain}/verifyRegistrantEmail`.

```csharp
var response = await client.Domains().VerifyEmailAsync("sample", "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainAsync("sample", "sample", "header-value", new[] { "sample" });
```

```json
{}
```

### DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/changeOfRegistrant`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync("sample", "sample", "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/changeOfRegistrant`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync("sample", "sample", "header-value");
```

```json
{}
```

### PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/dnssecRecords`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/dnssecRecords`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PutV2CustomersCustomerIdDomainsDomainNameServersAsync

Calls `PUT /v2/customers/{customerId}/domains/{domain}/nameServers`.

```csharp
var response = await client.Domains().PutV2CustomersCustomerIdDomainsDomainNameServersAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/privacy/forwarding`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync("sample", "sample", "header-value");
```

```json
{}
```

### PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/privacy/forwarding`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainRedeemAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/redeem`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRedeemAsync("sample", "sample", "header-value", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainRenewAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/renew`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRenewAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainTransferAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainTransferAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transfer/validate`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInAccept`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInCancel`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInRestart`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInRetry`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOut`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAsync("sample", "sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOutAccept`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOutReject`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync("sample", "sample", "header-value", "sample");
```

```json
{}
```

### DomainsForwardsDeleteAsync

Calls `DELETE /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsDeleteAsync("sample", "sample");
```

```json
{}
```

### DomainsForwardsGetAsync

Calls `GET /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsGetAsync("sample", "sample", true);
```

```json
{}
```

### DomainsForwardsPutAsync

Calls `PUT /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsPutAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### DomainsForwardsPostAsync

Calls `POST /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsPostAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainActionsAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/actions`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsAsync("sample", "sample", "header-value");
```

```json
{}
```

### DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/actions/{type}`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync("sample", "sample", "sample", "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/actions/{type}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync("sample", "sample", "sample", "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsNotificationsAsync

Calls `GET /v2/customers/{customerId}/domains/notifications`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsAsync("sample", "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsNotificationsOptInAsync

Calls `GET /v2/customers/{customerId}/domains/notifications/optIn`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsOptInAsync("sample", "header-value");
```

```json
{}
```

### PutV2CustomersCustomerIdDomainsNotificationsOptInAsync

Calls `PUT /v2/customers/{customerId}/domains/notifications/optIn`.

```csharp
var response = await client.Domains().PutV2CustomersCustomerIdDomainsNotificationsOptInAsync("sample", new[] { "sample" }, "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync

Calls `GET /v2/customers/{customerId}/domains/notifications/schemas/{type}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync

Calls `POST /v2/customers/{customerId}/domains/notifications/{notificationId}/acknowledge`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsRegisterAsync

Calls `POST /v2/customers/{customerId}/domains/register`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsRegisterAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync

Calls `GET /v2/customers/{customerId}/domains/register/schema/{tld}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync("sample", "sample", "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsRegisterValidateAsync

Calls `POST /v2/customers/{customerId}/domains/register/validate`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsRegisterValidateAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### GetV2DomainsMaintenancesAsync

Calls `GET /v2/domains/maintenances`.

```csharp
var response = await client.Domains().GetV2DomainsMaintenancesAsync("header-value", new[] { "sample" }, "sample", "sample", 1);
```

```json
{}
```

### GetV2DomainsMaintenancesMaintenanceIdAsync

Calls `GET /v2/domains/maintenances/{maintenanceId}`.

```csharp
var response = await client.Domains().GetV2DomainsMaintenancesMaintenanceIdAsync("sample", "header-value");
```

```json
{}
```

### GetV2DomainsUsageYyyymmAsync

Calls `GET /v2/domains/usage/{yyyymm}`.

```csharp
var response = await client.Domains().GetV2DomainsUsageYyyymmAsync("sample", "header-value", new[] { "sample" });
```

```json
{}
```

### PatchV2CustomersCustomerIdDomainsDomainContactsAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/contacts`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainContactsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/regenerateAuthCode`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync("sample", "sample", "header-value");
```

```json
{}
```

