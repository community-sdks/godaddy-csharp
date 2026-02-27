# CertificatesService

SSL certificate purchase, validation, lifecycle, and revocation endpoints.

## Accessor

```csharp
var service = client.Certificates();
```

## Endpoints

### CertificateCreateAsync

Calls `POST /v1/certificates`.

```csharp
var response = await client.Certificates().CertificateCreateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### CertificateValidateAsync

Calls `POST /v1/certificates/validate`.

```csharp
var response = await client.Certificates().CertificateValidateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### CertificateGetAsync

Calls `GET /v1/certificates/{certificateId}`.

```csharp
var response = await client.Certificates().CertificateGetAsync("sample");
```

```json
{}
```

### CertificateActionRetrieveAsync

Calls `GET /v1/certificates/{certificateId}/actions`.

```csharp
var response = await client.Certificates().CertificateActionRetrieveAsync("sample");
```

```json
{}
```

### CertificateResendEmailAsync

Calls `POST /v1/certificates/{certificateId}/email/{emailId}/resend`.

```csharp
var response = await client.Certificates().CertificateResendEmailAsync("sample", "sample");
```

```json
{}
```

### CertificateAlternateEmailAddressAsync

Calls `POST /v1/certificates/{certificateId}/email/resend/{emailAddress}`.

```csharp
var response = await client.Certificates().CertificateAlternateEmailAddressAsync("sample", new[] { "sample" });
```

```json
{}
```

### CertificateResendEmailAddressAsync

Calls `POST /v1/certificates/{certificateId}/email/{emailId}/resend/{emailAddress}`.

```csharp
var response = await client.Certificates().CertificateResendEmailAddressAsync("sample", "sample", new[] { "sample" });
```

```json
{}
```

### CertificateEmailHistoryAsync

Calls `GET /v1/certificates/{certificateId}/email/history`.

```csharp
var response = await client.Certificates().CertificateEmailHistoryAsync("sample");
```

```json
{}
```

### CertificateCallbackDeleteAsync

Calls `DELETE /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackDeleteAsync("sample");
```

```json
{}
```

### CertificateCallbackGetAsync

Calls `GET /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackGetAsync("sample");
```

```json
{}
```

### CertificateCallbackReplaceAsync

Calls `PUT /v1/certificates/{certificateId}/callback`.

```csharp
var response = await client.Certificates().CertificateCallbackReplaceAsync("sample", "sample");
```

```json
{}
```

### CertificateCancelAsync

Calls `POST /v1/certificates/{certificateId}/cancel`.

```csharp
var response = await client.Certificates().CertificateCancelAsync("sample");
```

```json
{}
```

### CertificateDownloadAsync

Calls `GET /v1/certificates/{certificateId}/download`.

```csharp
var response = await client.Certificates().CertificateDownloadAsync("sample");
```

```json
{}
```

### CertificateReissueAsync

Calls `POST /v1/certificates/{certificateId}/reissue`.

```csharp
var response = await client.Certificates().CertificateReissueAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### CertificateRenewAsync

Calls `POST /v1/certificates/{certificateId}/renew`.

```csharp
var response = await client.Certificates().CertificateRenewAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### CertificateRevokeAsync

Calls `POST /v1/certificates/{certificateId}/revoke`.

```csharp
var response = await client.Certificates().CertificateRevokeAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### CertificateSitesealGetAsync

Calls `GET /v1/certificates/{certificateId}/siteSeal`.

```csharp
var response = await client.Certificates().CertificateSitesealGetAsync("sample", "sample", "sample");
```

```json
{}
```

### CertificateVerifydomaincontrolAsync

Calls `POST /v1/certificates/{certificateId}/verifyDomainControl`.

```csharp
var response = await client.Certificates().CertificateVerifydomaincontrolAsync("sample");
```

```json
{}
```

### CertificateGetEntitlementAsync

Calls `GET /v2/certificates`.

```csharp
var response = await client.Certificates().CertificateGetEntitlementAsync("sample", true);
```

```json
{}
```

### CertificateCreateV2Async

Calls `POST /v2/certificates`.

```csharp
var response = await client.Certificates().CertificateCreateV2Async(JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

### CertificateDownloadEntitlementAsync

Calls `GET /v2/certificates/download`.

```csharp
var response = await client.Certificates().CertificateDownloadEntitlementAsync("sample");
```

```json
{}
```

### GetCustomerCertificatesByCustomerIdAsync

Calls `GET /v2/customers/{customerId}/certificates`.

```csharp
var response = await client.Certificates().GetCustomerCertificatesByCustomerIdAsync("sample", 1, 1);
```

```json
{}
```

### GetCertificateDetailByCertIdentifierAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}`.

```csharp
var response = await client.Certificates().GetCertificateDetailByCertIdentifierAsync("sample", "sample");
```

```json
{}
```

### GetDomainInformationByCertificateIdAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}/domainVerifications`.

```csharp
var response = await client.Certificates().GetDomainInformationByCertificateIdAsync("sample", "sample");
```

```json
{}
```

### GetDomainDetailsByDomainAsync

Calls `GET /v2/customers/{customerId}/certificates/{certificateId}/domainVerifications/{domain}`.

```csharp
var response = await client.Certificates().GetDomainDetailsByDomainAsync("sample", "sample", "sample");
```

```json
{}
```

### GetAcmeExternalAccountBindingAsync

Calls `GET /v2/customers/{customerId}/certificates/acme/externalAccountBinding`.

```csharp
var response = await client.Certificates().GetAcmeExternalAccountBindingAsync("sample");
```

```json
{}
```

### RetrieveSslByDomainResellerAsync

Calls `GET /v2/certificates/subscriptions/search`.

```csharp
var response = await client.Certificates().RetrieveSslByDomainResellerAsync(1, 1, "sample", new[] { "sample" }, "sample", "sample");
```

```json
{}
```

### RetrieveSslByDomainSubscriptionResellerAsync

Calls `GET /v2/certificates/subscription/{guid}`.

```csharp
var response = await client.Certificates().RetrieveSslByDomainSubscriptionResellerAsync("sample", 1, 1, "sample", new[] { "sample" }, "sample", "sample");
```

```json
{}
```

