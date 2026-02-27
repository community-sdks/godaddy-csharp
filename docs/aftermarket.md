# AftermarketService

Aftermarket listing and sales endpoints for secondary-market domain workflows.

## Accessor

```csharp
var service = client.Aftermarket();
```

## Endpoints

### GetListingsAsync

Calls `GET /v1/customers/{customerId}/auctions/listings`.

```csharp
var response = await client.Aftermarket().GetListingsAsync("sample", new[] { "sample" }, new[] { "sample" }, "sample", "sample", 1, 1);
```

```json
{}
```

### DeleteListingsAsync

Calls `DELETE /v1/aftermarket/listings`.

```csharp
var response = await client.Aftermarket().DeleteListingsAsync(new[] { "sample" });
```

```json
{}
```

### AddExpiryListingsAsync

Calls `POST /v1/aftermarket/listings/expiry`.

```csharp
var response = await client.Aftermarket().AddExpiryListingsAsync(new[] { "sample" });
```

```json
{}
```

