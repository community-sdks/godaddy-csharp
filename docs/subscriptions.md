# SubscriptionsService

Subscription listing and management endpoints for recurring products.

## Accessor

```csharp
var service = client.Subscriptions();
```

## Endpoints

### ListAsync

Calls `GET /v1/subscriptions`.

```csharp
var response = await client.Subscriptions().ListAsync("header-value", "header-value", "header-value", new[] { "sample" }, new[] { "sample" }, 1, 1, "sample");
```

```json
{}
```

### ProductGroupsAsync

Calls `GET /v1/subscriptions/productGroups`.

```csharp
var response = await client.Subscriptions().ProductGroupsAsync("header-value", "header-value");
```

```json
{}
```

### CancelAsync

Calls `DELETE /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().CancelAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "header-value");
```

```json
{}
```

### GetAsync

Calls `GET /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().GetAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "header-value");
```

```json
{}
```

### UpdateAsync

Calls `PATCH /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().UpdateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", JsonNode.Parse("""{"sample":true}""")!, "header-value");
```

```json
{}
```

