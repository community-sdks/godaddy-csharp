# OrdersService

Order lookup endpoints for commerce and fulfillment status.

## Accessor

```csharp
var service = client.Orders();
```

## Endpoints

### ListAsync

Calls `GET /v1/orders`.

```csharp
var response = await client.Orders().ListAsync("header-value", "sample", "sample", "sample", "sample", "sample", "sample", 1, 1, "sample", "header-value");
```

```json
{}
```

### GetAsync

Calls `GET /v1/orders/{orderId}`.

```csharp
var response = await client.Orders().GetAsync("sample", "header-value", "header-value", "header-value");
```

```json
{}
```

