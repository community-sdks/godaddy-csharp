# AbuseService

Client accessor: `client.Abuse()`

## Method Index

- [`GetTicketsAsync`](#getticketsasync)
- [`CreateTicketAsync`](#createticketasync)
- [`GetTicketInfoAsync`](#getticketinfoasync)
- [`GetTicketsV2Async`](#getticketsv2async)
- [`CreateTicketV2Async`](#createticketv2async)
- [`GetTicketInfoV2Async`](#getticketinfov2async)

## Endpoints

### GetTicketsAsync

Calls `GET /v1/abuse/tickets`.

```csharp
var response = await client.Abuse().GetTicketsAsync(
    new GetTicketsAsyncRequest(
        Type: "example",
        Closed: true,
        SourceDomainOrIp: "example.com",
        Target: "example",
        CreatedStart: "example",
        CreatedEnd: "example",
        Limit: 100,
        Offset: 0
    )
);
```

```json
{
  "pagination": {
    "first": "example",
    "last": "example",
    "next": "example",
    "previous": "example",
    "total": 1
  },
  "ticketIds": [
    "example"
  ]
}
```

### CreateTicketAsync

Calls `POST /v1/abuse/tickets`.

```csharp
var response = await client.Abuse().CreateTicketAsync(
    new CreateTicketAsyncRequest(
    Body: new CreateTicketLegacyBody(
      Source: "https://malicious.example/phish",
      Type: "PHISHING",
      Target: "Example Bank",
      Info: "Credential-harvesting page impersonating login flow"
    )
    )
);
```

```json
{
  "u_number": "example"
}
```

### GetTicketInfoAsync

Calls `GET /v1/abuse/tickets/{ticketId}`.

```csharp
var response = await client.Abuse().GetTicketInfoAsync(
    new GetTicketInfoAsyncRequest(
        TicketId: "TCK-100001"
    )
);
```

```json
{
  "closed": false,
  "closedAt": "2026-03-11T12:00:00Z",
  "createdAt": "2026-03-11T12:00:00Z",
  "domainIp": "example",
  "reporter": "example",
  "source": "example",
  "target": "example",
  "ticketId": "example",
  "type": "A_RECORD"
}
```

### GetTicketsV2Async

Calls `GET /v2/abuse/tickets`.

```csharp
var response = await client.Abuse().GetTicketsV2Async(
    new GetTicketsV2AsyncRequest(
        Type: "example",
        Closed: true,
        SourceDomainOrIp: "example.com",
        Target: "example",
        CreatedStart: "example",
        CreatedEnd: "example",
        Limit: 100,
        Offset: 0
    )
);
```

```json
{
  "pagination": {
    "first": "example",
    "last": "example",
    "next": "example",
    "previous": "example",
    "total": 1
  },
  "ticketIds": [
    "example"
  ]
}
```

### CreateTicketV2Async

Calls `POST /v2/abuse/tickets`.

```csharp
var response = await client.Abuse().CreateTicketV2Async(
    new CreateTicketV2AsyncRequest(
    Body: new CreateTicketV2Body(
      Source: "https://malicious.example/phish",
      Type: "PHISHING",
      Target: "Example Bank",
      Useragent: "DESKTOP",
      Proxy: "USA"
    )
    )
);
```

```json
{
  "u_number": "example"
}
```

### GetTicketInfoV2Async

Calls `GET /v2/abuse/tickets/{ticketId}`.

```csharp
var response = await client.Abuse().GetTicketInfoV2Async(
    new GetTicketInfoV2AsyncRequest(
        TicketId: "TCK-100001"
    )
);
```

```json
{
  "closed": false,
  "closedAt": "2026-03-11T12:00:00Z",
  "createdAt": "2026-03-11T12:00:00Z",
  "domainIp": "example",
  "reporter": "example",
  "source": "example",
  "target": "example",
  "ticketId": "example",
  "type": "A_RECORD",
  "closeReason": "ACTIONED"
}
```
