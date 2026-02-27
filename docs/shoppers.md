# ShoppersService

Shopper profile, account, and delegated access endpoints.

## Accessor

```csharp
var service = client.Shoppers();
```

## Endpoints

### CreateSubaccountAsync

Calls `POST /v1/shoppers/subaccount`.

```csharp
var response = await client.Shoppers().CreateSubaccountAsync(JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### GetAsync

Calls `GET /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().GetAsync(JsonNode.Parse("""{"sample":true}""")!, new[] { "sample" });
```

```json
{}
```

### UpdateAsync

Calls `POST /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().UpdateAsync(JsonNode.Parse("""{"sample":true}""")!, JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

### DeleteAsync

Calls `DELETE /v1/shoppers/{shopperId}`.

```csharp
var response = await client.Shoppers().DeleteAsync(JsonNode.Parse("""{"sample":true}""")!, "sample");
```

```json
{}
```

### GetStatusAsync

Calls `GET /v1/shoppers/{shopperId}/status`.

```csharp
var response = await client.Shoppers().GetStatusAsync(JsonNode.Parse("""{"sample":true}""")!, "sample");
```

```json
{}
```

### ChangePasswordAsync

Calls `PUT /v1/shoppers/{shopperId}/factors/password`.

```csharp
var response = await client.Shoppers().ChangePasswordAsync(JsonNode.Parse("""{"sample":true}""")!, JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

