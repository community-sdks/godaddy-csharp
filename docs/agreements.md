# AgreementsService

Client accessor: `client.Agreements()`

## Method Index

- [`GetAsync`](#getasync)

## Endpoints

### GetAsync

Calls `GET /v1/agreements`.

```csharp
var response = await client.Agreements().GetAsync(
    new GetAsyncRequest(
        XPrivateLabelId: 1,
        XMarketId: "en-US",
        Keys: new[] { "value" }
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
