# ParkingService

Domain parking optimization and template management endpoints.

## Accessor

```csharp
var service = client.Parking();
```

## Endpoints

### GetMetricsAsync

Calls `GET /v1/customers/{customerId}/parking/metrics`.

```csharp
var response = await client.Parking().GetMetricsAsync("sample", "sample", "sample", 1, 1, "header-value");
```

```json
{}
```

### GetMetricsByDomainAsync

Calls `GET /v1/customers/{customerId}/parking/metricsByDomain`.

```csharp
var response = await client.Parking().GetMetricsByDomainAsync("sample", "sample", "sample", new[] { "sample" }, "sample", "sample", 1, 1, "header-value");
```

```json
{}
```

