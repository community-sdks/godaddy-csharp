# AbuseService

Abuse reporting and ticket lookup endpoints for phishing, malware, and related investigations.

## Accessor

```csharp
var service = client.Abuse();
```

## Endpoints

### GetTicketsAsync

Calls `GET /v1/abuse/tickets`.

```csharp
var response = await client.Abuse().GetTicketsAsync("sample", true, "sample", "sample", "sample", "sample", 1, 1);
```

```json
{}
```

### CreateTicketAsync

Calls `POST /v1/abuse/tickets`.

```csharp
var response = await client.Abuse().CreateTicketAsync(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetTicketInfoAsync

Calls `GET /v1/abuse/tickets/{ticketId}`.

```csharp
var response = await client.Abuse().GetTicketInfoAsync("sample");
```

```json
{}
```

### GetTicketsV2Async

Calls `GET /v2/abuse/tickets`.

```csharp
var response = await client.Abuse().GetTicketsV2Async("sample", true, "sample", "sample", "sample", "sample", 1, 1);
```

```json
{}
```

### CreateTicketV2Async

Calls `POST /v2/abuse/tickets`.

```csharp
var response = await client.Abuse().CreateTicketV2Async(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetTicketInfoV2Async

Calls `GET /v2/abuse/tickets/{ticketId}`.

```csharp
var response = await client.Abuse().GetTicketInfoV2Async("sample");
```

```json
{}
```

