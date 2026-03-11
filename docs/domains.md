# DomainsService

Client accessor: `client.Domains()`

## Method Index

- [`ListAsync`](#listasync)
- [`GetAgreementAsync`](#getagreementasync)
- [`AvailableAsync`](#availableasync)
- [`AvailableBulkAsync`](#availablebulkasync)
- [`ContactsValidateAsync`](#contactsvalidateasync)
- [`PurchaseAsync`](#purchaseasync)
- [`SchemaAsync`](#schemaasync)
- [`ValidateAsync`](#validateasync)
- [`SuggestAsync`](#suggestasync)
- [`TldsAsync`](#tldsasync)
- [`CancelAsync`](#cancelasync)
- [`GetAsync`](#getasync)
- [`UpdateAsync`](#updateasync)
- [`UpdateContactsAsync`](#updatecontactsasync)
- [`CancelPrivacyAsync`](#cancelprivacyasync)
- [`PurchasePrivacyAsync`](#purchaseprivacyasync)
- [`RecordAddAsync`](#recordaddasync)
- [`RecordReplaceAsync`](#recordreplaceasync)
- [`RecordGetAsync`](#recordgetasync)
- [`RecordReplaceTypeNameAsync`](#recordreplacetypenameasync)
- [`RecordDeleteTypeNameAsync`](#recorddeletetypenameasync)
- [`RecordReplaceTypeAsync`](#recordreplacetypeasync)
- [`RenewAsync`](#renewasync)
- [`TransferInAsync`](#transferinasync)
- [`VerifyEmailAsync`](#verifyemailasync)
- [`GetV2CustomersCustomerIdDomainsDomainAsync`](#getv2customerscustomeriddomainsdomainasync)
- [`DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync`](#deletev2customerscustomeriddomainsdomainchangeofregistrantasync)
- [`GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync`](#getv2customerscustomeriddomainsdomainchangeofregistrantasync)
- [`PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync`](#patchv2customerscustomeriddomainsdomaindnssecrecordsasync)
- [`DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync`](#deletev2customerscustomeriddomainsdomaindnssecrecordsasync)
- [`PutV2CustomersCustomerIdDomainsDomainNameServersAsync`](#putv2customerscustomeriddomainsdomainnameserversasync)
- [`GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync`](#getv2customerscustomeriddomainsdomainprivacyforwardingasync)
- [`PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync`](#patchv2customerscustomeriddomainsdomainprivacyforwardingasync)
- [`PostV2CustomersCustomerIdDomainsDomainRedeemAsync`](#postv2customerscustomeriddomainsdomainredeemasync)
- [`PostV2CustomersCustomerIdDomainsDomainRenewAsync`](#postv2customerscustomeriddomainsdomainrenewasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferAsync`](#postv2customerscustomeriddomainsdomaintransferasync)
- [`GetV2CustomersCustomerIdDomainsDomainTransferAsync`](#getv2customerscustomeriddomainsdomaintransferasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync`](#postv2customerscustomeriddomainsdomaintransfervalidateasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync`](#postv2customerscustomeriddomainsdomaintransferinacceptasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync`](#postv2customerscustomeriddomainsdomaintransferincancelasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync`](#postv2customerscustomeriddomainsdomaintransferinrestartasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync`](#postv2customerscustomeriddomainsdomaintransferinretryasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferOutAsync`](#postv2customerscustomeriddomainsdomaintransferoutasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync`](#postv2customerscustomeriddomainsdomaintransferoutacceptasync)
- [`PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync`](#postv2customerscustomeriddomainsdomaintransferoutrejectasync)
- [`DomainsForwardsDeleteAsync`](#domainsforwardsdeleteasync)
- [`DomainsForwardsGetAsync`](#domainsforwardsgetasync)
- [`DomainsForwardsPutAsync`](#domainsforwardsputasync)
- [`DomainsForwardsPostAsync`](#domainsforwardspostasync)
- [`GetV2CustomersCustomerIdDomainsDomainActionsAsync`](#getv2customerscustomeriddomainsdomainactionsasync)
- [`DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync`](#deletev2customerscustomeriddomainsdomainactionstypeasync)
- [`GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync`](#getv2customerscustomeriddomainsdomainactionstypeasync)
- [`GetV2CustomersCustomerIdDomainsNotificationsAsync`](#getv2customerscustomeriddomainsnotificationsasync)
- [`GetV2CustomersCustomerIdDomainsNotificationsOptInAsync`](#getv2customerscustomeriddomainsnotificationsoptinasync)
- [`PutV2CustomersCustomerIdDomainsNotificationsOptInAsync`](#putv2customerscustomeriddomainsnotificationsoptinasync)
- [`GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync`](#getv2customerscustomeriddomainsnotificationsschemastypeasync)
- [`PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync`](#postv2customerscustomeriddomainsnotificationsnotificationidacknowledgeasync)
- [`PostV2CustomersCustomerIdDomainsRegisterAsync`](#postv2customerscustomeriddomainsregisterasync)
- [`GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync`](#getv2customerscustomeriddomainsregisterschematldasync)
- [`PostV2CustomersCustomerIdDomainsRegisterValidateAsync`](#postv2customerscustomeriddomainsregistervalidateasync)
- [`GetV2DomainsMaintenancesAsync`](#getv2domainsmaintenancesasync)
- [`GetV2DomainsMaintenancesMaintenanceIdAsync`](#getv2domainsmaintenancesmaintenanceidasync)
- [`GetV2DomainsUsageYyyymmAsync`](#getv2domainsusageyyyymmasync)
- [`PatchV2CustomersCustomerIdDomainsDomainContactsAsync`](#patchv2customerscustomeriddomainsdomaincontactsasync)
- [`PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync`](#postv2customerscustomeriddomainsdomainregenerateauthcodeasync)

## Endpoints


### ListAsync

Calls `GET /v1/domains`.

```csharp
var response = await client.Domains().ListAsync(
    new ListAsyncRequest(
        XShopperId: "123456789",
        Statuses: new[] { "value" },
        StatusGroups: new[] { "value" },
        Limit: 100,
        Marker: "example",
        Includes: new[] { "contacts", "privacy" },
        ModifiedDate: "example"
    )
);
```

```json
[
  {
    "authCode": "example",
    "contactAdmin": {
      "addressMailing": {},
      "email": "admin@example.com",
      "fax": "example",
      "jobTitle": "example",
      "nameFirst": "example",
      "nameLast": "example",
      "nameMiddle": "example",
      "organization": "example",
      "phone": "example"
    },
    "contactBilling": {
      "addressMailing": {},
      "email": "admin@example.com",
      "fax": "example",
      "jobTitle": "example",
      "nameFirst": "example",
      "nameLast": "example",
      "nameMiddle": "example",
      "organization": "example",
      "phone": "example"
    },
    "contactRegistrant": {
      "addressMailing": {},
      "email": "admin@example.com",
      "fax": "example",
      "jobTitle": "example",
      "nameFirst": "example",
      "nameLast": "example",
      "nameMiddle": "example",
      "organization": "example",
      "phone": "example"
    },
    "contactTech": {
      "addressMailing": {},
      "email": "admin@example.com",
      "fax": "example",
      "jobTitle": "example",
      "nameFirst": "example",
      "nameLast": "example",
      "nameMiddle": "example",
      "organization": "example",
      "phone": "example"
    },
    "createdAt": "example",
    "deletedAt": "example",
    "transferAwayEligibleAt": "example",
    "domain": "example",
    "domainId": 1,
    "expirationProtected": false,
    "expires": "example",
    "exposeWhois": false,
    "holdRegistrar": false,
    "locked": false,
    "nameServers": [
      "example"
    ],
    "privacy": false,
    "registrarCreatedAt": "2026-03-11T12:00:00Z",
    "renewAuto": false,
    "renewDeadline": "example",
    "renewable": false,
    "status": "example",
    "transferProtected": false
  }
]
```

### GetAgreementAsync

Calls `GET /v1/domains/agreements`.

```csharp
var response = await client.Domains().GetAgreementAsync(
    new GetAgreementAsyncRequest(
        XMarketId: "en-US",
        Tlds: new[] { "com", "net" },
        Privacy: true,
        ForTransfer: true
    )
);
```

```json
[
  {
    "agreementKey": "example",
    "content": "example",
    "title": "example",
    "url": "example"
  }
]
```

### AvailableAsync

Calls `GET /v1/domains/available`.

```csharp
var response = await client.Domains().AvailableAsync(
    new AvailableAsyncRequest(
        Domain: "example.com",
        CheckType: "example",
        ForTransfer: true
    )
);
```

```json
{
  "available": false,
  "currency": "example",
  "definitive": false,
  "domain": "example",
  "period": 1,
  "price": 1
}
```

### AvailableBulkAsync

Calls `POST /v1/domains/available`.

```csharp
var response = await client.Domains().AvailableBulkAsync(
    new AvailableBulkAsyncRequest(
        Domains: new AvailableBulkAsyncRequestDomains(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PurchaseAsync

Calls `POST /v1/domains/purchase`.

```csharp
var response = await client.Domains().PurchaseAsync(
    new PurchaseAsyncRequest(
        XShopperId: "123456789",
        Body: new PurchaseAsyncRequestBody(
            Consent: new PurchaseAsyncRequestBodyConsent(),
            ContactAdmin: new PurchaseAsyncRequestBodyContactAdmin(),
            ContactBilling: new PurchaseAsyncRequestBodyContactBilling(),
            ContactRegistrant: new PurchaseAsyncRequestBodyContactRegistrant(),
            ContactTech: new PurchaseAsyncRequestBodyContactTech(),
            Domain: "example.com",
            NameServers: new[] { new string>() },
            Period: 1,
            Privacy: true,
            RenewAuto: true
        )
    )
);
```

```json
{
  "currency": "example",
  "itemCount": 1,
  "orderId": 1,
  "total": 1
}
```

### SchemaAsync

Calls `GET /v1/domains/purchase/schema/{tld}`.

```csharp
var response = await client.Domains().SchemaAsync(
    new SchemaAsyncRequest(
        Tld: "com"
    )
);
```

```json
{
  "id": "example",
  "models": {},
  "properties": {},
  "required": [
    "example"
  ]
}
```

### ValidateAsync

Calls `POST /v1/domains/purchase/validate`.

```csharp
var response = await client.Domains().ValidateAsync(
    new ValidateAsyncRequest(
        Body: new ValidateAsyncRequestBody(
            Consent: new ValidateAsyncRequestBodyConsent(),
            ContactAdmin: new ValidateAsyncRequestBodyContactAdmin(),
            ContactBilling: new ValidateAsyncRequestBodyContactBilling(),
            ContactRegistrant: new ValidateAsyncRequestBodyContactRegistrant(),
            ContactTech: new ValidateAsyncRequestBodyContactTech(),
            Domain: "example.com",
            NameServers: new[] { new string>() },
            Period: 1,
            Privacy: true,
            RenewAuto: true
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### SuggestAsync

Calls `GET /v1/domains/suggest`.

```csharp
var response = await client.Domains().SuggestAsync(
    new SuggestAsyncRequest(
        XShopperId: "123456789",
        Query: "example",
        Country: "example",
        City: "example",
        Sources: new[] { "value" },
        Tlds: new[] { "com", "net" },
        LengthMax: 1,
        LengthMin: 1,
        Limit: 100,
        WaitMs: 1
    )
);
```

```json
[
  {
    "domain": "example"
  }
]
```

### TldsAsync

Calls `GET /v1/domains/tlds`.

```csharp
var response = await client.Domains().TldsAsync(
    new TldsAsyncRequest(

    )
);
```

```json
[
  {
    "name": "example",
    "type": "COUNTRY_CODE"
  }
]
```

### CancelAsync

Calls `DELETE /v1/domains/{domain}`.

```csharp
var response = await client.Domains().CancelAsync(
    new CancelAsyncRequest(
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetAsync

Calls `GET /v1/domains/{domain}`.

```csharp
var response = await client.Domains().GetAsync(
    new GetAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "authCode": "example",
  "contactAdmin": {
    "addressMailing": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "email": "admin@example.com",
    "fax": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "organization": "example",
    "phone": "example"
  },
  "contactBilling": {
    "addressMailing": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "email": "admin@example.com",
    "fax": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "organization": "example",
    "phone": "example"
  },
  "contactRegistrant": {
    "addressMailing": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "email": "admin@example.com",
    "fax": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "organization": "example",
    "phone": "example"
  },
  "contactTech": {
    "addressMailing": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "email": "admin@example.com",
    "fax": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "organization": "example",
    "phone": "example"
  },
  "createdAt": "example",
  "deletedAt": "example",
  "transferAwayEligibleAt": "example",
  "domain": "example",
  "domainId": 1,
  "expirationProtected": false,
  "expires": "example",
  "exposeRegistrantOrganization": false,
  "exposeWhois": false,
  "holdRegistrar": false,
  "locked": false,
  "nameServers": [
    "example"
  ],
  "privacy": false,
  "registrarCreatedAt": "2026-03-11T12:00:00Z",
  "renewAuto": false,
  "renewDeadline": "example",
  "status": "example",
  "subaccountId": "example",
  "transferProtected": false,
  "verifications": {
    "domainName": {
      "status": {}
    },
    "realName": {
      "status": {}
    }
  }
}
```

### UpdateAsync

Calls `PATCH /v1/domains/{domain}`.

```csharp
var response = await client.Domains().UpdateAsync(
    new UpdateAsyncRequest(
        Domain: "example.com",
        XShopperId: "123456789",
        Body: new UpdateAsyncRequestBody(
            Locked: true,
            NameServers: new[] { new string>() },
            RenewAuto: true,
            SubaccountId: "example",
            ExposeRegistrantOrganization: true,
            ExposeWhois: true,
            Consent: new UpdateAsyncRequestBodyConsent()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### UpdateContactsAsync

Calls `PATCH /v1/domains/{domain}/contacts`.

```csharp
var response = await client.Domains().UpdateContactsAsync(
    new UpdateContactsAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Contacts: new UpdateContactsAsyncRequestContacts(
            ContactAdmin: new UpdateContactsAsyncRequestContactsContactAdmin(),
            ContactBilling: new UpdateContactsAsyncRequestContactsContactBilling(),
            ContactRegistrant: new UpdateContactsAsyncRequestContactsContactRegistrant(),
            ContactTech: new UpdateContactsAsyncRequestContactsContactTech()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CancelPrivacyAsync

Calls `DELETE /v1/domains/{domain}/privacy`.

```csharp
var response = await client.Domains().CancelPrivacyAsync(
    new CancelPrivacyAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### PurchasePrivacyAsync

Calls `POST /v1/domains/{domain}/privacy/purchase`.

```csharp
var response = await client.Domains().PurchasePrivacyAsync(
    new PurchasePrivacyAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Body: new PurchasePrivacyAsyncRequestBody(
            Consent: new PurchasePrivacyAsyncRequestBodyConsent()
        )
    )
);
```

```json
{
  "currency": "example",
  "itemCount": 1,
  "orderId": 1,
  "total": 1
}
```

### RecordAddAsync

Calls `PATCH /v1/domains/{domain}/records`.

```csharp
var response = await client.Domains().RecordAddAsync(
    new RecordAddAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Records: new RecordAddAsyncRequestRecords(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### RecordReplaceAsync

Calls `PUT /v1/domains/{domain}/records`.

```csharp
var response = await client.Domains().RecordReplaceAsync(
    new RecordReplaceAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Records: new RecordReplaceAsyncRequestRecords(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### RecordGetAsync

Calls `GET /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordGetAsync(
    new RecordGetAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Type: "example",
        Name: "example",
        Offset: 0,
        Limit: 100
    )
);
```

```json
[
  {
    "data": "example",
    "name": "example",
    "port": 1,
    "priority": 1,
    "protocol": "example",
    "service": "example",
    "ttl": 1,
    "type": "A",
    "weight": 1
  }
]
```

### RecordReplaceTypeNameAsync

Calls `PUT /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordReplaceTypeNameAsync(
    new RecordReplaceTypeNameAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Type: "example",
        Name: "example",
        Records: new RecordReplaceTypeNameAsyncRequestRecords(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### RecordDeleteTypeNameAsync

Calls `DELETE /v1/domains/{domain}/records/{type}/{name}`.

```csharp
var response = await client.Domains().RecordDeleteTypeNameAsync(
    new RecordDeleteTypeNameAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Type: "example",
        Name: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### RecordReplaceTypeAsync

Calls `PUT /v1/domains/{domain}/records/{type}`.

```csharp
var response = await client.Domains().RecordReplaceTypeAsync(
    new RecordReplaceTypeAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Type: "example",
        Records: new RecordReplaceTypeAsyncRequestRecords(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### RenewAsync

Calls `POST /v1/domains/{domain}/renew`.

```csharp
var response = await client.Domains().RenewAsync(
    new RenewAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Body: new RenewAsyncRequestBody(
            Period: 1
        )
    )
);
```

```json
{
  "currency": "example",
  "itemCount": 1,
  "orderId": 1,
  "total": 1
}
```

### TransferInAsync

Calls `POST /v1/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().TransferInAsync(
    new TransferInAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com",
        Body: new TransferInAsyncRequestBody(
            AuthCode: "example",
            Consent: new TransferInAsyncRequestBodyConsent(),
            Period: 1,
            Privacy: true,
            RenewAuto: true,
            ContactAdmin: new TransferInAsyncRequestBodyContactAdmin(),
            ContactBilling: new TransferInAsyncRequestBodyContactBilling(),
            ContactRegistrant: new TransferInAsyncRequestBodyContactRegistrant(),
            ContactTech: new TransferInAsyncRequestBodyContactTech()
        )
    )
);
```

```json
{
  "currency": "example",
  "itemCount": 1,
  "orderId": 1,
  "total": 1
}
```

### VerifyEmailAsync

Calls `POST /v1/domains/{domain}/verifyRegistrantEmail`.

```csharp
var response = await client.Domains().VerifyEmailAsync(
    new VerifyEmailAsyncRequest(
        XShopperId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainAsync(
    new GetV2CustomersCustomerIdDomainsDomainAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Includes: new[] { "contacts", "privacy" }
    )
);
```

```json
{
  "domainId": "example",
  "domain": "example",
  "subaccountId": "example",
  "status": "ACTIVE",
  "expiresAt": "2026-03-11T12:00:00Z",
  "expirationProtected": false,
  "holdRegistrar": false,
  "locked": false,
  "privacy": false,
  "registrarCreatedAt": "2026-03-11T12:00:00Z",
  "renewAuto": false,
  "renewDeadline": "2026-03-11T12:00:00Z",
  "transferProtected": false,
  "createdAt": "2026-03-11T12:00:00Z",
  "deletedAt": "2026-03-11T12:00:00Z",
  "modifiedAt": "2026-03-11T12:00:00Z",
  "transferAwayEligibleAt": "2026-03-11T12:00:00Z",
  "authCode": "example",
  "nameServers": [
    "example"
  ],
  "hostnames": [
    "example"
  ],
  "renewal": {
    "renewable": false,
    "price": 1,
    "currency": "example"
  },
  "verifications": {
    "icann": "COMPLETED",
    "realName": "APPROVED",
    "domainName": "APPROVED"
  },
  "contacts": {
    "registrant": {
      "contactId": {},
      "encoding": {},
      "nameFirst": {},
      "nameMiddle": {},
      "nameLast": {},
      "organization": {},
      "jobTitle": {},
      "email": {},
      "phone": {},
      "fax": {},
      "addressMailing": {},
      "exposeRegistrantOrganization": {},
      "exposeWhois": {},
      "metadata": {},
      "tlds": {},
      "_createdAt": {},
      "_modifiedAt": {},
      "_deleted": {},
      "_revision": {}
    },
    "admin": {
      "contactId": {},
      "encoding": {},
      "nameFirst": {},
      "nameMiddle": {},
      "nameLast": {},
      "organization": {},
      "jobTitle": {},
      "email": {},
      "phone": {},
      "fax": {},
      "addressMailing": {},
      "exposeRegistrantOrganization": {},
      "exposeWhois": {},
      "metadata": {},
      "tlds": {},
      "_createdAt": {},
      "_modifiedAt": {},
      "_deleted": {},
      "_revision": {}
    },
    "tech": {
      "contactId": {},
      "encoding": {},
      "nameFirst": {},
      "nameMiddle": {},
      "nameLast": {},
      "organization": {},
      "jobTitle": {},
      "email": {},
      "phone": {},
      "fax": {},
      "addressMailing": {},
      "exposeRegistrantOrganization": {},
      "exposeWhois": {},
      "metadata": {},
      "tlds": {},
      "_createdAt": {},
      "_modifiedAt": {},
      "_deleted": {},
      "_revision": {}
    },
    "billing": {
      "contactId": {},
      "encoding": {},
      "nameFirst": {},
      "nameMiddle": {},
      "nameLast": {},
      "organization": {},
      "jobTitle": {},
      "email": {},
      "phone": {},
      "fax": {},
      "addressMailing": {},
      "exposeRegistrantOrganization": {},
      "exposeWhois": {},
      "metadata": {},
      "tlds": {},
      "_createdAt": {},
      "_modifiedAt": {},
      "_deleted": {},
      "_revision": {}
    }
  },
  "actions": [
    {
      "type": "AUTH_CODE_PURCHASE",
      "origination": "USER",
      "createdAt": "2026-03-11T12:00:00Z",
      "startedAt": "2026-03-11T12:00:00Z",
      "completedAt": "2026-03-11T12:00:00Z",
      "modifiedAt": "2026-03-11T12:00:00Z",
      "status": "ACCEPTED",
      "reason": {},
      "requestId": "example"
    }
  ],
  "dnssecRecords": [
    {
      "algorithm": "RSAMD5",
      "keyTag": 1,
      "digestType": "SHA1",
      "digest": "example",
      "flags": "ZSK",
      "publicKey": "example",
      "maxSignatureLife": 1
    }
  ],
  "registryStatusCodes": [
    "ADD_PERIOD"
  ]
}
```

### DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/changeOfRegistrant`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(
    new DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/changeOfRegistrant`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync(
    new GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "createDate": "2026-03-11T12:00:00Z",
  "gainingContact": {
    "email": "admin@example.com",
    "firstName": "example",
    "lastName": "example",
    "organization": "example"
  },
  "losingContact": {
    "email": "admin@example.com",
    "firstName": "example",
    "lastName": "example",
    "organization": "example"
  },
  "otherDomainsAffected": 1,
  "shopperEmail": "admin@example.com"
}
```

### PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/dnssecRecords`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(
    new PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/dnssecRecords`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync(
    new DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsyncRequestBody(

        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PutV2CustomersCustomerIdDomainsDomainNameServersAsync

Calls `PUT /v2/customers/{customerId}/domains/{domain}/nameServers`.

```csharp
var response = await client.Domains().PutV2CustomersCustomerIdDomainsDomainNameServersAsync(
    new PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PutV2CustomersCustomerIdDomainsDomainNameServersAsyncRequestBody(
            NameServers: new[] { new string>() }
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/privacy/forwarding`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(
    new GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "privateEmail": "example",
  "forwardingEmail": "example",
  "emailPreference": "EMAIL_FILTER"
}
```

### PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/privacy/forwarding`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync(
    new PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsyncRequestBody(
            PrivateEmailType: "PHISHING",
            ForwardingEmail: "admin@example.com",
            EmailPreference: "admin@example.com"
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainRedeemAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/redeem`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRedeemAsync(
    new PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBody(
            Consent: new PostV2CustomersCustomerIdDomainsDomainRedeemAsyncRequestBodyConsent()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainRenewAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/renew`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRenewAsync(
    new PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBody(
            Expires: "example",
            Consent: new PostV2CustomersCustomerIdDomainsDomainRenewAsyncRequestBodyConsent(),
            Period: 1
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody(
            AuthCode: "example",
            Period: 1,
            RenewAuto: true,
            Privacy: true,
            IdentityDocumentId: "example",
            Consent: new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyConsent(),
            Contacts: new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContacts(),
            Metadata: new PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyMetadata()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainTransferAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/transfer`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainTransferAsync(
    new GetV2CustomersCustomerIdDomainsDomainTransferAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "transferStatusCodes": [
    "CLIENT_APPROVED"
  ]
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transfer/validate`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBody(
            AuthCode: "example",
            Period: 1,
            RenewAuto: true,
            Privacy: true,
            IdentityDocumentId: "example",
            Consent: new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyConsent(),
            Contacts: new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContacts(),
            Metadata: new PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyMetadata()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInAccept`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsyncRequestBody(
            AuthCode: "example"
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInCancel`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInRestart`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferInRetry`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsyncRequestBody(
            AuthCode: "example"
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOut`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferOutAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Registrar: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOutAccept`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/transferOutReject`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync(
    new PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Reason: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### DomainsForwardsDeleteAsync

Calls `DELETE /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsDeleteAsync(
    new DomainsForwardsDeleteAsyncRequest(
        CustomerId: "123456789",
        Fqdn: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### DomainsForwardsGetAsync

Calls `GET /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsGetAsync(
    new DomainsForwardsGetAsyncRequest(
        CustomerId: "123456789",
        Fqdn: "example",
        IncludeSubs: true
    )
);
```

```json
[
  {
    "fqdn": "example",
    "type": "MASKED",
    "url": "example",
    "mask": {
      "title": "example",
      "description": "example",
      "keywords": "example"
    }
  }
]
```

### DomainsForwardsPutAsync

Calls `PUT /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsPutAsync(
    new DomainsForwardsPutAsyncRequest(
        CustomerId: "123456789",
        Fqdn: "example",
        Body: new DomainsForwardsPutAsyncRequestBody(
            Type: "PHISHING",
            Url: "example",
            Mask: new DomainsForwardsPutAsyncRequestBodyMask()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### DomainsForwardsPostAsync

Calls `POST /v2/customers/{customerId}/domains/forwards/{fqdn}`.

```csharp
var response = await client.Domains().DomainsForwardsPostAsync(
    new DomainsForwardsPostAsyncRequest(
        CustomerId: "123456789",
        Fqdn: "example",
        Body: new DomainsForwardsPostAsyncRequestBody(
            Type: "PHISHING",
            Url: "example",
            Mask: new DomainsForwardsPostAsyncRequestBodyMask()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainActionsAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/actions`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsAsync(
    new GetV2CustomersCustomerIdDomainsDomainActionsAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
[
  {
    "type": "AUTH_CODE_PURCHASE",
    "origination": "USER",
    "createdAt": "2026-03-11T12:00:00Z",
    "startedAt": "2026-03-11T12:00:00Z",
    "completedAt": "2026-03-11T12:00:00Z",
    "modifiedAt": "2026-03-11T12:00:00Z",
    "status": "ACCEPTED",
    "reason": {
      "code": "example",
      "message": "example",
      "fields": [
        {}
      ]
    },
    "requestId": "example"
  }
]
```

### DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync

Calls `DELETE /v2/customers/{customerId}/domains/{domain}/actions/{type}`.

```csharp
var response = await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync(
    new DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Type: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync

Calls `GET /v2/customers/{customerId}/domains/{domain}/actions/{type}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync(
    new GetV2CustomersCustomerIdDomainsDomainActionsTypeAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Type: "example"
    )
);
```

```json
{
  "type": "AUTH_CODE_PURCHASE",
  "origination": "USER",
  "createdAt": "2026-03-11T12:00:00Z",
  "startedAt": "2026-03-11T12:00:00Z",
  "completedAt": "2026-03-11T12:00:00Z",
  "modifiedAt": "2026-03-11T12:00:00Z",
  "status": "ACCEPTED",
  "reason": {
    "code": "example",
    "message": "example",
    "fields": [
      {}
    ]
  },
  "requestId": "example"
}
```

### GetV2CustomersCustomerIdDomainsNotificationsAsync

Calls `GET /v2/customers/{customerId}/domains/notifications`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsAsync(
    new GetV2CustomersCustomerIdDomainsNotificationsAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789"
    )
);
```

```json
{
  "notificationId": "example",
  "type": "AUTH_CODE_PURCHASE",
  "resource": "example",
  "resourceType": "CONTACT",
  "status": "AWAITING",
  "addedAt": "2026-03-11T12:00:00Z",
  "requestId": "example",
  "metadata": {}
}
```

### GetV2CustomersCustomerIdDomainsNotificationsOptInAsync

Calls `GET /v2/customers/{customerId}/domains/notifications/optIn`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsOptInAsync(
    new GetV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789"
    )
);
```

```json
[
  {
    "notificationId": "example",
    "type": "AUTH_CODE_PURCHASE",
    "resource": "example",
    "resourceType": "CONTACT",
    "status": "AWAITING",
    "addedAt": "2026-03-11T12:00:00Z",
    "requestId": "example",
    "metadata": {}
  }
]
```

### PutV2CustomersCustomerIdDomainsNotificationsOptInAsync

Calls `PUT /v2/customers/{customerId}/domains/notifications/optIn`.

```csharp
var response = await client.Domains().PutV2CustomersCustomerIdDomainsNotificationsOptInAsync(
    new PutV2CustomersCustomerIdDomainsNotificationsOptInAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Types: new[] { "value" }
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync

Calls `GET /v2/customers/{customerId}/domains/notifications/schemas/{type}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync(
    new GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Type: "example"
    )
);
```

```json
{
  "id": "example",
  "models": {},
  "properties": {},
  "required": [
    "example"
  ]
}
```

### PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync

Calls `POST /v2/customers/{customerId}/domains/notifications/{notificationId}/acknowledge`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync(
    new PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        NotificationId: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsRegisterAsync

Calls `POST /v2/customers/{customerId}/domains/register`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsRegisterAsync(
    new PostV2CustomersCustomerIdDomainsRegisterAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Body: new PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody(
            Domain: "example.com",
            Consent: new PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyConsent(),
            Period: 1,
            NameServers: new[] { new string>() },
            RenewAuto: true,
            Privacy: true,
            Contacts: new PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContacts(),
            Metadata: new PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyMetadata()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync

Calls `GET /v2/customers/{customerId}/domains/register/schema/{tld}`.

```csharp
var response = await client.Domains().GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync(
    new GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Tld: "com"
    )
);
```

```json
{
  "id": "example",
  "models": {},
  "properties": {},
  "required": [
    "example"
  ]
}
```

### PostV2CustomersCustomerIdDomainsRegisterValidateAsync

Calls `POST /v2/customers/{customerId}/domains/register/validate`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsRegisterValidateAsync(
    new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Body: new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody(
            Domain: "example.com",
            Consent: new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyConsent(),
            Period: 1,
            NameServers: new[] { new string>() },
            RenewAuto: true,
            Privacy: true,
            Contacts: new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContacts(),
            Metadata: new PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyMetadata()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### GetV2DomainsMaintenancesAsync

Calls `GET /v2/domains/maintenances`.

```csharp
var response = await client.Domains().GetV2DomainsMaintenancesAsync(
    new GetV2DomainsMaintenancesAsyncRequest(
        XRequestId: "req-12345",
        Status: "example",
        ModifiedAtAfter: "example",
        StartsAtAfter: "example",
        Limit: 100
    )
);
```

```json
{
  "createdAt": "2026-03-11T12:00:00Z",
  "endsAt": "2026-03-11T12:00:00Z",
  "environment": "OTE",
  "maintenanceId": "example",
  "modifiedAt": "2026-03-11T12:00:00Z",
  "reason": "EMERGENCY",
  "startsAt": "2026-03-11T12:00:00Z",
  "status": "ACTIVE",
  "summary": "example",
  "tlds": [
    "example"
  ],
  "type": "API"
}
```

### GetV2DomainsMaintenancesMaintenanceIdAsync

Calls `GET /v2/domains/maintenances/{maintenanceId}`.

```csharp
var response = await client.Domains().GetV2DomainsMaintenancesMaintenanceIdAsync(
    new GetV2DomainsMaintenancesMaintenanceIdAsyncRequest(
        XRequestId: "req-12345",
        MaintenanceId: "example"
    )
);
```

```json
{
  "createdAt": "2026-03-11T12:00:00Z",
  "endsAt": "2026-03-11T12:00:00Z",
  "environment": "OTE",
  "maintenanceId": "example",
  "modifiedAt": "2026-03-11T12:00:00Z",
  "reason": "EMERGENCY",
  "startsAt": "2026-03-11T12:00:00Z",
  "status": "ACTIVE",
  "summary": "example",
  "systems": [
    {
      "name": "DOMAIN_CHECKS",
      "impact": [
        {}
      ]
    }
  ],
  "tlds": [
    "example"
  ],
  "type": "API"
}
```

### GetV2DomainsUsageYyyymmAsync

Calls `GET /v2/domains/usage/{yyyymm}`.

```csharp
var response = await client.Domains().GetV2DomainsUsageYyyymmAsync(
    new GetV2DomainsUsageYyyymmAsyncRequest(
        XRequestId: "req-12345",
        Yyyymm: "example",
        Includes: new[] { "contacts", "privacy" }
    )
);
```

```json
{
  "details": [
    {
      "path": "example",
      "total": 1
    }
  ],
  "quota": 1,
  "total": 1,
  "yyyymm": "example"
}
```

### PatchV2CustomersCustomerIdDomainsDomainContactsAsync

Calls `PATCH /v2/customers/{customerId}/domains/{domain}/contacts`.

```csharp
var response = await client.Domains().PatchV2CustomersCustomerIdDomainsDomainContactsAsync(
    new PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com",
        Body: new PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody(
            IdentityDocumentId: "example",
            Contacts: new PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContacts()
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync

Calls `POST /v2/customers/{customerId}/domains/{domain}/regenerateAuthCode`.

```csharp
var response = await client.Domains().PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync(
    new PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsyncRequest(
        XRequestId: "req-12345",
        CustomerId: "123456789",
        Domain: "example.com"
    )
);
```

```json
{
  "status": "ok"
}
```
