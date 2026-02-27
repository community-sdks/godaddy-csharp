# AgreementsService

Agreement retrieval endpoints for legal terms and consent workflows.

## Accessor

```csharp
var service = client.Agreements();
```

## Endpoints

### GetAsync

Calls `GET /v1/agreements`.

```csharp
var response = await client.Agreements().GetAsync(new[] { "sample" }, "header-value", "header-value");
```

```json
{}
```

