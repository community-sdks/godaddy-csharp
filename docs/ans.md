# AnsService

Authoritative DNS record and nameserver management endpoints.

## Accessor

```csharp
var service = client.Ans();
```

## Endpoints

### SearchANSNameAsync

Calls `GET /v1/agents`.

```csharp
var response = await client.Ans().SearchANSNameAsync("sample", "sample", "sample", "sample", 1, 1);
```

```json
{}
```

### RegisterAgentAsync

Calls `POST /v1/agents/register`.

```csharp
var response = await client.Ans().RegisterAgentAsync(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### ResolveANSNameAsync

Calls `POST /v1/agents/resolution`.

```csharp
var response = await client.Ans().ResolveANSNameAsync(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetAgentAsync

Calls `GET /v1/agents/{agentId}`.

```csharp
var response = await client.Ans().GetAgentAsync("sample");
```

```json
{}
```

### ValidateRegistrationAsync

Calls `POST /v1/agents/{agentId}/verify-acme`.

```csharp
var response = await client.Ans().ValidateRegistrationAsync("sample");
```

```json
{}
```

### VerifyDnsRecordsAsync

Calls `POST /v1/agents/{agentId}/verify-dns`.

```csharp
var response = await client.Ans().VerifyDnsRecordsAsync("sample");
```

```json
{}
```

### GetAgentIdentityCertificateByAgentIdAsync

Calls `GET /v1/agents/{agentId}/certificates/identity`.

```csharp
var response = await client.Ans().GetAgentIdentityCertificateByAgentIdAsync("sample");
```

```json
{}
```

### SubmitAgentIdentityCsrByAgentIdAsync

Calls `POST /v1/agents/{agentId}/certificates/identity`.

```csharp
var response = await client.Ans().SubmitAgentIdentityCsrByAgentIdAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetAgentServerCertificateByAgentIdAsync

Calls `GET /v1/agents/{agentId}/certificates/server`.

```csharp
var response = await client.Ans().GetAgentServerCertificateByAgentIdAsync("sample");
```

```json
{}
```

### SubmitAgentServerCsrByAgentIdAsync

Calls `POST /v1/agents/{agentId}/certificates/server`.

```csharp
var response = await client.Ans().SubmitAgentServerCsrByAgentIdAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetAgentCsrStatusByAgentIdAsync

Calls `GET /v1/agents/{agentId}/csrs/{csrId}/status`.

```csharp
var response = await client.Ans().GetAgentCsrStatusByAgentIdAsync("sample", "sample");
```

```json
{}
```

### GetAgentEventsAsync

Calls `GET /v1/agents/events`.

```csharp
var response = await client.Ans().GetAgentEventsAsync("header-value", "sample", "sample", 1);
```

```json
{}
```

