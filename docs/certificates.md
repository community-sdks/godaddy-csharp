# CertificatesService

Client accessor: `client.Certificates()`

## Method Index

- [`CertificateCreateAsync`](#certificatecreateasync)
- [`CertificateValidateAsync`](#certificatevalidateasync)
- [`CertificateGetAsync`](#certificategetasync)
- [`CertificateActionRetrieveAsync`](#certificateactionretrieveasync)
- [`CertificateResendEmailAsync`](#certificateresendemailasync)
- [`CertificateAlternateEmailAddressAsync`](#certificatealternateemailaddressasync)
- [`CertificateResendEmailAddressAsync`](#certificateresendemailaddressasync)
- [`CertificateEmailHistoryAsync`](#certificateemailhistoryasync)
- [`CertificateCallbackDeleteAsync`](#certificatecallbackdeleteasync)
- [`CertificateCallbackGetAsync`](#certificatecallbackgetasync)
- [`CertificateCallbackReplaceAsync`](#certificatecallbackreplaceasync)
- [`CertificateCancelAsync`](#certificatecancelasync)
- [`CertificateDownloadAsync`](#certificatedownloadasync)
- [`CertificateReissueAsync`](#certificatereissueasync)
- [`CertificateRenewAsync`](#certificaterenewasync)
- [`CertificateRevokeAsync`](#certificaterevokeasync)
- [`CertificateSitesealGetAsync`](#certificatesitesealgetasync)
- [`CertificateVerifydomaincontrolAsync`](#certificateverifydomaincontrolasync)
- [`CertificateGetEntitlementAsync`](#certificategetentitlementasync)
- [`CertificateCreateV2CertificatesAsync`](#certificatecreatev2certificatesasync)
- [`CertificateDownloadEntitlementAsync`](#certificatedownloadentitlementasync)
- [`GetCustomerCertificatesByCustomerIdAsync`](#getcustomercertificatesbycustomeridasync)
- [`GetCertificateDetailByCertIdentifierAsync`](#getcertificatedetailbycertidentifierasync)
- [`GetDomainInformationByCertificateIdAsync`](#getdomaininformationbycertificateidasync)
- [`GetDomainDetailsByDomainAsync`](#getdomaindetailsbydomainasync)
- [`GetAcmeExternalAccountBindingAsync`](#getacmeexternalaccountbindingasync)
- [`RetrieveSslByDomainResellerAsync`](#retrievesslbydomainresellerasync)
- [`RetrieveSslByDomainSubscriptionResellerAsync`](#retrievesslbydomainsubscriptionresellerasync)

## Endpoints


### CertificateCreateAsync

Calls `POST /v1/certificates`.

```csharp
var response = await client.Certificates().CertificateCreateAsync(
    new CertificateCreateAsyncRequest(
        XMarketId: "en-US",
        CertificateCreate: new CertificateCreateAsyncRequestCertificateCreate(
            CallbackUrl: "example",
            CommonName: "example",
            Contact: new CertificateCreateAsyncRequestCertificateCreateContact(),
            Csr: "example",
            IntelVPro: true,
            Organization: new CertificateCreateAsyncRequestCertificateCreateOrganization(),
            Period: 1,
            ProductType: "PHISHING",
            RootType: "PHISHING",
            SlotSize: "example",
            SubjectAlternativeNames: new[] { new string>() }
        )
    )
);
```

```json
{
  "certificateId": "example",
  "subscriptionId": "example",
  "subscriptionCreatedForOrder": false
}
```

### CertificateValidateAsync

Calls `POST /v1/certificates/validate`.

```csharp
var response = await client.Certificates().CertificateValidateAsync(
    new CertificateValidateAsyncRequest(
        XMarketId: "en-US",
        CertificateCreate: new CertificateValidateAsyncRequestCertificateCreate(
            CallbackUrl: "example",
            CommonName: "example",
            Contact: new CertificateValidateAsyncRequestCertificateCreateContact(),
            Csr: "example",
            IntelVPro: true,
            Organization: new CertificateValidateAsyncRequestCertificateCreateOrganization(),
            Period: 1,
            ProductType: "PHISHING",
            RootType: "PHISHING",
            SlotSize: "example",
            SubjectAlternativeNames: new[] { new string>() }
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateGetAsync

Calls `GET /v1/certificates/{certificateId}`.

```csharp
var response = await client.Certificates().CertificateGetAsync(
    new CertificateGetAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "certificateId": "example",
  "commonName": "example",
  "contact": {
    "email": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "phone": "example",
    "suffix": "example"
  },
  "createdAt": "2026-03-11T12:00:00Z",
  "deniedReason": "example",
  "organization": {
    "address": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "assumedName": "example",
    "jurisdictionOfIncorporation": {
      "city": {},
      "country": {},
      "county": {},
      "state": {}
    },
    "name": "example",
    "phone": "example",
    "registrationAgent": "example",
    "registrationNumber": "example"
  },
  "period": 1,
  "productType": "DV_SSL",
  "progress": 1,
  "revokedAt": "2026-03-11T12:00:00Z",
  "rootType": "GODADDY_SHA_1",
  "serialNumber": "example",
  "serialNumberHex": "example",
  "slotSize": "FIVE",
  "status": "PENDING_ISSUANCE",
  "subjectAlternativeNames": [
    {
      "status": "PENDING",
      "subjectAlternativeName": "example"
    }
  ],
  "validEnd": "2026-03-11T12:00:00Z",
  "validStart": "2026-03-11T12:00:00Z"
}
```

### CertificateActionRetrieveAsync

Calls `GET /v1/certificates/{certificateId}/actions`.

```csharp
var response = await client.Certificates().CertificateActionRetrieveAsync(
    new CertificateActionRetrieveAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
[
  {
    "createdAt": "2026-03-11T12:00:00Z",
    "type": "CERTIFICATE_ISSUED"
  }
]
```

### CertificateResendEmailAsync

Calls `POST /v1/certificates/{certificateId}/email/{emailId}/resend`.

```csharp
var response = await client.Certificates().CertificateResendEmailAsync(
    new CertificateResendEmailAsyncRequest(
        CertificateId: "987654",
        EmailId: "admin@example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateAlternateEmailAddressAsync

Calls `POST /v1/certificates/{certificateId}/email/resend/{emailAddress}`.

```csharp
var response = await client.Certificates().CertificateAlternateEmailAddressAsync(
    new CertificateAlternateEmailAddressAsyncRequest(
        CertificateId: "987654",
        EmailAddress: "admin@example.com"
    )
);
```

```json
{
  "id": 1,
  "accountId": 1,
  "templateType": "example",
  "fromType": "example",
  "recipients": "example",
  "body": "example",
  "dateEntered": "2026-03-11T12:00:00Z",
  "subject": "example"
}
```

### CertificateResendEmailAddressAsync

Calls `POST /v1/certificates/{certificateId}/email/{emailId}/resend/{emailAddress}`.

```csharp
var response = await client.Certificates().CertificateResendEmailAddressAsync(
    new CertificateResendEmailAddressAsyncRequest(
        CertificateId: "987654",
        EmailId: "admin@example.com",
        EmailAddress: "admin@example.com"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateEmailHistoryAsync

Calls `GET /v1/certificates/{certificateId}/email/history`.

```csharp
var response = await client.Certificates().CertificateEmailHistoryAsync(
    new CertificateEmailHistoryAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "id": 1,
  "accountId": 1,
  "templateType": "example",
  "fromType": "example",
  "recipients": "example",
  "body": "example",
  "dateEntered": "2026-03-11T12:00:00Z",
  "subject": "example"
}
```

### CertificateCallbackDeleteAsync

Calls `DELETE /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackDeleteAsync(
    new CertificateCallbackDeleteAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateCallbackGetAsync

Calls `GET /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackGetAsync(
    new CertificateCallbackGetAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "callbackUrl": "example"
}
```

### CertificateCallbackReplaceAsync

Calls `PUT /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackReplaceAsync(
    new CertificateCallbackReplaceAsyncRequest(
        CertificateId: "987654",
        CallbackUrl: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateCancelAsync

Calls `POST /v1/certificates/{certificateId}/cancel`.

```csharp
var response = await client.Certificates().CertificateCancelAsync(
    new CertificateCancelAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateDownloadAsync

Calls `GET /v1/certificates/{certificateId}/download`.

```csharp
var response = await client.Certificates().CertificateDownloadAsync(
    new CertificateDownloadAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "pems": {
    "certificate": "example",
    "cross": "example",
    "intermediate": "example",
    "root": "example"
  },
  "serialNumber": "example"
}
```

### CertificateReissueAsync

Calls `POST /v1/certificates/{certificateId}/reissue`.

```csharp
var response = await client.Certificates().CertificateReissueAsync(
    new CertificateReissueAsyncRequest(
        CertificateId: "987654",
        ReissueCreate: new CertificateReissueAsyncRequestReissueCreate(
            CallbackUrl: "example",
            CommonName: "example",
            Csr: "example",
            DelayExistingRevoke: 1,
            RootType: "PHISHING",
            SubjectAlternativeNames: new[] { new string>() },
            ForceDomainRevetting: new[] { new string>() }
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateRenewAsync

Calls `POST /v1/certificates/{certificateId}/renew`.

```csharp
var response = await client.Certificates().CertificateRenewAsync(
    new CertificateRenewAsyncRequest(
        CertificateId: "987654",
        RenewCreate: new CertificateRenewAsyncRequestRenewCreate(
            CallbackUrl: "example",
            CommonName: "example",
            Csr: "example",
            Period: 1,
            RootType: "PHISHING",
            SubjectAlternativeNames: new[] { new string>() }
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateRevokeAsync

Calls `POST /v1/certificates/{certificateId}/revoke`.

```csharp
var response = await client.Certificates().CertificateRevokeAsync(
    new CertificateRevokeAsyncRequest(
        CertificateId: "987654",
        CertificateRevoke: new CertificateRevokeAsyncRequestCertificateRevoke(
            Reason: "example"
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateSitesealGetAsync

Calls `GET /v1/certificates/{certificateId}/siteSeal`.

```csharp
var response = await client.Certificates().CertificateSitesealGetAsync(
    new CertificateSitesealGetAsyncRequest(
        CertificateId: "987654",
        Theme: "example",
        Locale: "example"
    )
);
```

```json
{
  "html": "example"
}
```

### CertificateVerifydomaincontrolAsync

Calls `POST /v1/certificates/{certificateId}/verifyDomainControl`.

```csharp
var response = await client.Certificates().CertificateVerifydomaincontrolAsync(
    new CertificateVerifydomaincontrolAsyncRequest(
        CertificateId: "987654"
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateGetEntitlementAsync

Calls `GET /v2/certificates`.

```csharp
var response = await client.Certificates().CertificateGetEntitlementAsync(
    new CertificateGetEntitlementAsyncRequest(
        EntitlementId: "example",
        Latest: true
    )
);
```

```json
[
  {
    "certificateId": "example",
    "commonName": "example",
    "contact": {
      "email": "example",
      "jobTitle": "example",
      "nameFirst": "example",
      "nameLast": "example",
      "nameMiddle": "example",
      "phone": "example",
      "suffix": "example"
    },
    "createdAt": "2026-03-11T12:00:00Z",
    "deniedReason": "example",
    "organization": {
      "address": {},
      "assumedName": "example",
      "jurisdictionOfIncorporation": {},
      "name": "example",
      "phone": "example",
      "registrationAgent": "example",
      "registrationNumber": "example"
    },
    "period": 1,
    "productType": "DV_SSL",
    "progress": 1,
    "revokedAt": "2026-03-11T12:00:00Z",
    "rootType": "GODADDY_SHA_1",
    "serialNumber": "example",
    "serialNumberHex": "example",
    "slotSize": "FIVE",
    "status": "PENDING_ISSUANCE",
    "subjectAlternativeNames": [
      {
        "status": {},
        "subjectAlternativeName": {}
      }
    ],
    "validEnd": "2026-03-11T12:00:00Z",
    "validStart": "2026-03-11T12:00:00Z"
  }
]
```

### CertificateCreateV2CertificatesAsync

Calls `POST /v2/certificates`.

```csharp
var response = await client.Certificates().CertificateCreateV2CertificatesAsync(
    new CertificateCreateV2CertificatesAsyncRequest(
        XMarketId: "en-US",
        SubscriptionCertificateCreate: new CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreate(
            CallbackUrl: "example",
            CommonName: "example",
            Contact: new CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreateContact(),
            Csr: "example",
            IntelVPro: true,
            Organization: new CertificateCreateV2CertificatesAsyncRequestSubscriptionCertificateCreateOrganization(),
            Period: 1,
            TermType: "PHISHING",
            ProductType: "PHISHING",
            RootType: "PHISHING",
            SlotSize: "example",
            SubjectAlternativeNames: new[] { new string>() }
        )
    )
);
```

```json
{
  "status": "ok"
}
```

### CertificateDownloadEntitlementAsync

Calls `GET /v2/certificates/download`.

```csharp
var response = await client.Certificates().CertificateDownloadEntitlementAsync(
    new CertificateDownloadEntitlementAsyncRequest(
        EntitlementId: "example"
    )
);
```

```json
{
  "pems": {
    "certificate": "example",
    "cross": "example",
    "intermediate": "example",
    "root": "example"
  },
  "serialNumber": "example"
}
```

### GetCustomerCertificatesByCustomerIdAsync

Calls `GET /v2/customers/{customerId}/certificates`.

```csharp
var response = await client.Certificates().GetCustomerCertificatesByCustomerIdAsync(
    new GetCustomerCertificatesByCustomerIdAsyncRequest(
        Param1: "example",
        Param2: "example",
        Param3: "example"
    )
);
```

```json
{
  "certificates": [
    {
      "certificateId": "example",
      "commonName": "example",
      "period": 1,
      "type": "DV_SSL",
      "status": "ISSUED",
      "createdAt": "2026-03-11T12:00:00Z",
      "completedAt": "2026-03-11T12:00:00Z",
      "validEndAt": "2026-03-11T12:00:00Z",
      "validStartAt": "2026-03-11T12:00:00Z",
      "revokedAt": "2026-03-11T12:00:00Z",
      "renewalAvailable": false,
      "serialNumber": "example",
      "slotSize": "FIVE",
      "subjectAlternativeNames": [
        {}
      ]
    }
  ],
  "pagination": {
    "first": "example",
    "previous": "example",
    "next": "example",
    "last": "example",
    "total": 1
  }
}
```

### GetCertificateDetailByCertIdentifierAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}`.

```csharp
var response = await client.Certificates().GetCertificateDetailByCertIdentifierAsync(
    new GetCertificateDetailByCertIdentifierAsyncRequest(
        Param1: "example",
        Param2: "example"
    )
);
```

```json
{
  "certificateId": "example",
  "commonName": "example",
  "period": 1,
  "type": "DV_SSL",
  "status": "PENDING_ISSUANCE",
  "createdAt": "2026-03-11T12:00:00Z",
  "completedAt": "2026-03-11T12:00:00Z",
  "validEndAt": "2026-03-11T12:00:00Z",
  "validStartAt": "2026-03-11T12:00:00Z",
  "revokedAt": "2026-03-11T12:00:00Z",
  "renewalAvailable": false,
  "serialNumber": "example",
  "serialNumberHex": "example",
  "slotSize": "FIVE",
  "subjectAlternativeNames": [
    "example"
  ],
  "contact": {
    "email": "example",
    "jobTitle": "example",
    "nameFirst": "example",
    "nameLast": "example",
    "nameMiddle": "example",
    "phone": "example",
    "suffix": "example"
  },
  "organization": {
    "address": {
      "address1": {},
      "address2": {},
      "city": {},
      "country": {},
      "postalCode": {},
      "state": {}
    },
    "assumedName": "example",
    "jurisdictionOfIncorporation": {
      "city": {},
      "country": {},
      "county": {},
      "state": {}
    },
    "name": "example",
    "phone": "example",
    "registrationAgent": "example",
    "registrationNumber": "example"
  },
  "csr": "example",
  "rootType": "GODADDY_SHA_1",
  "deniedReason": "example",
  "progress": 1
}
```

### GetDomainInformationByCertificateIdAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}/domainVerifications`.

```csharp
var response = await client.Certificates().GetDomainInformationByCertificateIdAsync(
    new GetDomainInformationByCertificateIdAsyncRequest(
        Param1: "example",
        Param2: "example"
    )
);
```

```json
[
  {
    "domain": "example",
    "domainEntityId": 1,
    "dceToken": "example",
    "status": "COMPLETED",
    "createdAt": "2026-03-11T12:00:00Z",
    "modifiedAt": "2026-03-11T12:00:00Z",
    "type": "DOMAIN_CONTROL_EMAIL",
    "usage": "COMMON_NAME"
  }
]
```

### GetDomainDetailsByDomainAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}/domainVerifications/{domain}`.

```csharp
var response = await client.Certificates().GetDomainDetailsByDomainAsync(
    new GetDomainDetailsByDomainAsyncRequest(
        Param1: "example",
        Param2: "example",
        Param3: "example"
    )
);
```

```json
{
  "domain": "example",
  "domainEntityId": 1,
  "dceToken": "example",
  "status": "COMPLETED",
  "createdAt": "2026-03-11T12:00:00Z",
  "modifiedAt": "2026-03-11T12:00:00Z",
  "type": "DOMAIN_CONTROL_EMAIL",
  "usage": "COMMON_NAME",
  "certificateAuthorityAuthorization": {
    "status": "PENDING",
    "queryPaths": [
      "example"
    ],
    "recommendations": [
      "ADD_CA_TO_CAA"
    ],
    "completedAt": "2026-03-11T12:00:00Z"
  }
}
```

### GetAcmeExternalAccountBindingAsync

Calls `GET /v2/customers/{customerId}/certificates/acme/externalAccountBinding`.

```csharp
var response = await client.Certificates().GetAcmeExternalAccountBindingAsync(
    new GetAcmeExternalAccountBindingAsyncRequest(
        Param1: "example"
    )
);
```

```json
{
  "directoryUrl": "example",
  "keyId": "example",
  "hmacKey": "example"
}
```

### RetrieveSslByDomainResellerAsync

Calls `GET /v2/certificates/subscriptions/search`.

```csharp
var response = await client.Certificates().RetrieveSslByDomainResellerAsync(
    new RetrieveSslByDomainResellerAsyncRequest(
        Param1: "example",
        Param2: "example",
        Param3: "example",
        Param4: "example",
        Param5: "example",
        Param6: "example"
    )
);
```

```json
{
  "currentPage": 1,
  "data": [
    {
      "currentPage": {},
      "data": {},
      "pageSize": {},
      "total": {}
    }
  ],
  "pageSize": 1,
  "total": 1
}
```

### RetrieveSslByDomainSubscriptionResellerAsync

Calls `GET /v2/certificates/subscription/{guid}`.

```csharp
var response = await client.Certificates().RetrieveSslByDomainSubscriptionResellerAsync(
    new RetrieveSslByDomainSubscriptionResellerAsyncRequest(
        Param1: "example",
        Param2: "example",
        Param3: "example",
        Param4: "example",
        Param5: "example",
        Param6: "example",
        Param7: "example"
    )
);
```

```json
{
  "allowedDomains": [
    {}
  ],
  "domain": "example",
  "guid": "example",
  "maxDomains": 1,
  "subscriptionEndDate": "example",
  "subscriptionStartDate": "example",
  "subscriptionStatus": "ACTIVE",
  "currentPage": 1,
  "data": [
    {
      "certificateId": {},
      "completionDate": {},
      "domain": {},
      "period": {},
      "requestDate": {},
      "revocationDate": {},
      "sans": {},
      "serialNumber": {},
      "slotSize": {},
      "status": {},
      "type": {},
      "validEndDate": {},
      "validStartDate": {},
      "validationType": {}
    }
  ],
  "pageSize": 1,
  "total": 1
}
```
