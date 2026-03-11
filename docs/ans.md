# AnsService

Client accessor: `client.Ans()`

## Method Index

- [`SearchANSNameAsync`](#searchansnameasync)
- [`RegisterAgentAsync`](#registeragentasync)
- [`ResolveANSNameAsync`](#resolveansnameasync)
- [`GetAgentAsync`](#getagentasync)
- [`RevokeAgentAsync`](#revokeagentasync)
- [`ValidateRegistrationAsync`](#validateregistrationasync)
- [`VerifyDnsRecordsAsync`](#verifydnsrecordsasync)
- [`GetAgentIdentityCertificateByAgentIdAsync`](#getagentidentitycertificatebyagentidasync)
- [`SubmitAgentIdentityCsrByAgentIdAsync`](#submitagentidentitycsrbyagentidasync)
- [`GetAgentServerCertificateByAgentIdAsync`](#getagentservercertificatebyagentidasync)
- [`SubmitAgentServerCsrByAgentIdAsync`](#submitagentservercsrbyagentidasync)
- [`GetAgentCsrStatusByAgentIdAsync`](#getagentcsrstatusbyagentidasync)
- [`GetAgentEventsAsync`](#getagenteventsasync)

## Endpoints


### SearchANSNameAsync

Calls `GET /v1/agents`.

```csharp
var response = await client.Ans().SearchANSNameAsync(
    new SearchANSNameAsyncRequest(
        AgentDisplayName: "example",
        Version: "example",
        AgentHost: "example",
        Protocol: "example",
        Limit: 100,
        Offset: 0
    )
);
```

```json
{
  "agents": [
    {
      "agentDescription": "example",
      "agentHost": "example",
      "agentDisplayName": "example",
      "ansName": "example",
      "agentId": "example",
      "endpoints": [
        {}
      ],
      "links": [
        {}
      ],
      "registrationTimestamp": "example",
      "ttl": 1,
      "version": "example"
    }
  ],
  "hasMore": false,
  "limit": 1,
  "offset": 1,
  "returnedCount": 1,
  "searchCriteria": {
    "agentHost": "example",
    "agentDisplayName": "example",
    "protocol": "A2A",
    "version": "example"
  },
  "totalCount": 1
}
```

### RegisterAgentAsync

Calls `POST /v1/agents/register`.

```csharp
var response = await client.Ans().RegisterAgentAsync(
    new RegisterAgentAsyncRequest(
        Body: new RegisterAgentAsyncRequestBody(
            AgentDescription: "example",
            AgentDisplayName: "example",
            AgentHost: "example",
            Endpoints: new[] { new RegisterAgentAsyncRequestBodyEndpointsItem() },
            IdentityCsrPEM: "example",
            ServerCertificateChainPEM: "example",
            ServerCertificatePEM: "example",
            ServerCsrPEM: "example",
            Version: "example"
        )
    )
);
```

```json
{
  "agentId": "550e8400-e29b-41d4-a716-446655440000",
  "ansName": "ans://v1.0.0.external-domain.com",
  "challenge": {
    "dnsRecord": {
      "name": "_acme-challenge.external-domain.com",
      "type": "TXT",
      "value": "xyz123abc456"
    },
    "keyAuthorization": "xyz123abc456.thumbprint",
    "token": "xyz123abc456",
    "type": "DNS_01"
  },
  "expiresAt": "2025-11-13T16:30:00Z",
  "links": [
    {
      "href": "https://api.godaddy.com/v1/agents/550e8400-e29b-41d4-a716-446655440000/challenge",
      "rel": "challenge"
    }
  ],
  "nextSteps": [
    {
      "action": "CONFIGURE_DNS",
      "description": "Configure DNS TXT record for ACME validation",
      "endpoint": "https://api.godaddy.com/v1/agents/550e8400-e29b-41d4-a716-446655440000/verify-acme"
    }
  ],
  "status": "PENDING_VALIDATION"
}
```

### ResolveANSNameAsync

Calls `POST /v1/agents/resolution`.

```csharp
var response = await client.Ans().ResolveANSNameAsync(
    new ResolveANSNameAsyncRequest(
        Body: new ResolveANSNameAsyncRequestBody(
            AgentHost: "example",
            Version: "example"
        )
    )
);
```

```json
{
  "ansName": "ans://v1.0.0.myagent.example.com",
  "links": [
    {
      "href": "https://api.godaddy.com/v1/agents/550e8400-e29b-41d4-a716-446655440000",
      "rel": "agent-details"
    },
    {
      "href": "https://myagent.example.com/api/v1",
      "rel": "agent-endpoint"
    }
  ]
}
```

### GetAgentAsync

Calls `GET /v1/agents/{agentId}`.

```csharp
var response = await client.Ans().GetAgentAsync(
    new GetAgentAsyncRequest(
        AgentId: "example"
    )
);
```

```json
{
  "agentDescription": "example",
  "agentHost": "example",
  "agentId": "example",
  "agentDisplayName": "example",
  "agentStatus": "PENDING_VALIDATION",
  "ansName": "example",
  "endpoints": [
    {
      "agentUrl": "example",
      "metaDataUrl": "example",
      "documentationUrl": "example",
      "protocol": "A2A",
      "functions": [
        {}
      ],
      "transports": [
        {}
      ]
    }
  ],
  "lastRenewalTimestamp": "example",
  "links": [
    {
      "href": "example",
      "rel": "example"
    }
  ],
  "registrationTimestamp": "example",
  "version": "example",
  "registrationPending": {
    "ansName": "example",
    "challenges": [
      {}
    ],
    "dnsRecords": [
      {}
    ],
    "expiresAt": "example",
    "links": [
      {}
    ],
    "nextSteps": [
      {}
    ],
    "status": "PENDING_VALIDATION"
  }
}
```

### RevokeAgentAsync

Calls `POST /v1/agents/{agentId}/revoke`.

```csharp
var response = await client.Ans().RevokeAgentAsync(
    new RevokeAgentAsyncRequest(
        AgentId: "example",
        Body: new RevokeAgentAsyncRequestBody(
            Reason: "example",
            Comments: "example"
        )
    )
);
```

```json
{
  "agentId": "example",
  "ansName": "example",
  "status": "PENDING_VALIDATION",
  "revokedAt": "example",
  "reason": "KEY_COMPROMISE",
  "links": [
    {
      "href": "example",
      "rel": "example"
    }
  ],
  "dnsRecordsToRemove": [
    {
      "name": "example",
      "priority": 1,
      "purpose": "DISCOVERY",
      "required": false,
      "ttl": 1,
      "type": "HTTPS",
      "value": "example"
    }
  ]
}
```

### ValidateRegistrationAsync

Calls `POST /v1/agents/{agentId}/verify-acme`.

```csharp
var response = await client.Ans().ValidateRegistrationAsync(
    new ValidateRegistrationAsyncRequest(
        AgentId: "example"
    )
);
```

```json
{
  "completedSteps": [
    "example"
  ],
  "createdAt": "example",
  "expiresAt": "example",
  "pendingSteps": [
    "example"
  ],
  "phase": "INITIALIZATION",
  "status": "PENDING_VALIDATION",
  "updatedAt": "example"
}
```

### VerifyDnsRecordsAsync

Calls `POST /v1/agents/{agentId}/verify-dns`.

```csharp
var response = await client.Ans().VerifyDnsRecordsAsync(
    new VerifyDnsRecordsAsyncRequest(
        AgentId: "example"
    )
);
```

```json
{
  "completedSteps": [
    "example"
  ],
  "createdAt": "example",
  "expiresAt": "example",
  "pendingSteps": [
    "example"
  ],
  "phase": "INITIALIZATION",
  "status": "PENDING_VALIDATION",
  "updatedAt": "example"
}
```

### GetAgentIdentityCertificateByAgentIdAsync

Calls `GET /v1/agents/{agentId}/certificates/identity`.

```csharp
var response = await client.Ans().GetAgentIdentityCertificateByAgentIdAsync(
    new GetAgentIdentityCertificateByAgentIdAsyncRequest(
        AgentId: "example"
    )
);
```

```json
[
  {
    "certificateIssuer": "example",
    "certificatePEM": "example",
    "certificatePublicKeyAlgorithm": "example",
    "certificateSerialNumber": "example",
    "certificateSignatureAlgorithm": "example",
    "certificateSubject": "example",
    "certificateValidFrom": "example",
    "certificateValidTo": "example",
    "csrId": "example"
  }
]
```

### SubmitAgentIdentityCsrByAgentIdAsync

Calls `POST /v1/agents/{agentId}/certificates/identity`.

```csharp
var response = await client.Ans().SubmitAgentIdentityCsrByAgentIdAsync(
    new SubmitAgentIdentityCsrByAgentIdAsyncRequest(
        AgentId: "example",
        Body: new SubmitAgentIdentityCsrByAgentIdAsyncRequestBody(
            CsrPEM: "example"
        )
    )
);
```

```json
{
  "csrId": "example",
  "message": "example"
}
```

### GetAgentServerCertificateByAgentIdAsync

Calls `GET /v1/agents/{agentId}/certificates/server`.

```csharp
var response = await client.Ans().GetAgentServerCertificateByAgentIdAsync(
    new GetAgentServerCertificateByAgentIdAsyncRequest(
        AgentId: "example"
    )
);
```

```json
[
  {
    "certificateIssuer": "example",
    "certificatePEM": "example",
    "certificatePublicKeyAlgorithm": "example",
    "certificateSerialNumber": "example",
    "certificateSignatureAlgorithm": "example",
    "certificateSubject": "example",
    "certificateValidFrom": "example",
    "certificateValidTo": "example",
    "csrId": "example"
  }
]
```

### SubmitAgentServerCsrByAgentIdAsync

Calls `POST /v1/agents/{agentId}/certificates/server`.

```csharp
var response = await client.Ans().SubmitAgentServerCsrByAgentIdAsync(
    new SubmitAgentServerCsrByAgentIdAsyncRequest(
        AgentId: "example",
        Body: new SubmitAgentServerCsrByAgentIdAsyncRequestBody(
            CsrPEM: "example"
        )
    )
);
```

```json
{
  "csrId": "example",
  "message": "example"
}
```

### GetAgentCsrStatusByAgentIdAsync

Calls `GET /v1/agents/{agentId}/csrs/{csrId}/status`.

```csharp
var response = await client.Ans().GetAgentCsrStatusByAgentIdAsync(
    new GetAgentCsrStatusByAgentIdAsyncRequest(
        AgentId: "example",
        CsrId: "example"
    )
);
```

```json
{
  "csrId": "example",
  "failureReason": "example",
  "status": "PENDING",
  "submittedAt": "example",
  "type": "SERVER",
  "updatedAt": "example"
}
```

### GetAgentEventsAsync

Calls `GET /v1/agents/events`.

```csharp
var response = await client.Ans().GetAgentEventsAsync(
    new GetAgentEventsAsyncRequest(
        XRequestId: "req-12345",
        ProviderId: "example",
        LastLogId: "example",
        Limit: 100
    )
);
```

```json
{
  "items": [
    {
      "logId": "example",
      "eventType": "AGENT_DEPRECATED",
      "createdAt": "example",
      "expiresAt": "example",
      "agentId": "example",
      "ansName": "example",
      "agentHost": "example",
      "agentDisplayName": "example",
      "agentDescription": "example",
      "version": "example",
      "providerId": "example",
      "endpoints": [
        {}
      ]
    }
  ],
  "lastLogId": "example"
}
```
