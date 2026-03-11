# ShoppersService

Client accessor: `client.Shoppers()`

## Method Index

- [`CreateSubaccountAsync`](#createsubaccountasync)
- [`GetAsync`](#getasync)
- [`UpdateAsync`](#updateasync)
- [`DeleteAsync`](#deleteasync)
- [`GetStatusAsync`](#getstatusasync)
- [`ChangePasswordAsync`](#changepasswordasync)

## Endpoints


### CreateSubaccountAsync

Calls `POST /v1/shoppers/subaccount`.

```csharp
var response = await client.Shoppers().CreateSubaccountAsync(
    new CreateSubaccountAsyncRequest(
        Subaccount: new CreateSubaccountAsyncRequestSubaccount(
            Email: "admin@example.com",
            ExternalId: 1,
            MarketId: "example",
            NameFirst: "example",
            NameLast: "example",
            Password: "example"
        )
    )
);
```

```json
{
  "customerId": "example",
  "shopperId": "example"
}
```

### GetAsync

Calls `GET /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().GetAsync(
    new GetAsyncRequest(
        ShopperId: "123456789",
        Includes: new[] { "contacts", "privacy" }
    )
);
```

```json
{
  "customerId": "example",
  "email": "admin@example.com",
  "externalId": 1,
  "marketId": "example",
  "nameFirst": "example",
  "nameLast": "example",
  "shopperId": "example"
}
```

### UpdateAsync

Calls `POST /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().UpdateAsync(
    new UpdateAsyncRequest(
        ShopperId: "123456789",
        Shopper: new UpdateAsyncRequestShopper(
            Email: "admin@example.com",
            ExternalId: 1,
            MarketId: "example",
            NameFirst: "example",
            NameLast: "example"
        )
    )
);
```

```json
{
  "customerId": "example",
  "shopperId": "example"
}
```

### DeleteAsync

Calls `DELETE /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().DeleteAsync(
    new DeleteAsyncRequest(
        ShopperId: "123456789",
        AuditClientIp: "example"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetStatusAsync

Calls `GET /v1/shoppers/{shopperId}/status`.

```csharp
var response = await client.Shoppers().GetStatusAsync(
    new GetStatusAsyncRequest(
        ShopperId: "123456789",
        AuditClientIp: "example"
    )
);
```

```json
{
  "billingState": "ABANDONED"
}
```

### ChangePasswordAsync

Calls `PUT /v1/shoppers/{shopperId}/factors/password`.

```csharp
var response = await client.Shoppers().ChangePasswordAsync(
    new ChangePasswordAsyncRequest(
        ShopperId: "123456789",
        Secret: new ChangePasswordAsyncRequestSecret(
            Secret: "example"
        )
    )
);
```

```json
{
  "customerId": "example",
  "shopperId": "example"
}
```
