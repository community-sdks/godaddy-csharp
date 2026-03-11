# ParkingService

Client accessor: `client.Parking()`

## Method Index

- [`GetMetricsAsync`](#getmetricsasync)
- [`GetMetricsByDomainAsync`](#getmetricsbydomainasync)

## Endpoints

### GetMetricsAsync

Calls `GET /v1/customers/{customerId}/parking/metrics`.

```csharp
var response = await client.Parking().GetMetricsAsync(
    new GetMetricsAsyncRequest(
        CustomerId: "123456789",
        PeriodStartPtz: "example",
        PeriodEndPtz: "example",
        Limit: 100,
        Offset: 0,
        XRequestId: "req-12345"
    )
);
```

```json
{
  "currencyId": "USD",
  "metrics": [
    {
      "adClickCount": 1,
      "periodPtz": "2026-03-11T12:00:00Z",
      "revenue": 1,
      "visitCount": 1
    }
  ],
  "pagination": {
    "first": "example",
    "last": "example",
    "next": "example",
    "previous": "example",
    "total": 1
  }
}
```

### GetMetricsByDomainAsync

Calls `GET /v1/customers/{customerId}/parking/metricsByDomain`.

```csharp
var response = await client.Parking().GetMetricsByDomainAsync(
    new GetMetricsByDomainAsyncRequest(
        CustomerId: "123456789",
        StartDate: "example",
        EndDate: "example",
        Domains: "example.com",
        DomainLike: "example.com",
        PortfolioId: "example",
        Limit: 100,
        Offset: 0,
        XRequestId: "req-12345"
    )
);
```

```json
{
  "currencyId": "USD",
  "metrics": [
    {
      "adClickCount": 1,
      "domain": "example",
      "revenue": 1,
      "visitCount": 1,
      "pageViewCount": 1
    }
  ],
  "pagination": {
    "first": "example",
    "last": "example",
    "next": "example",
    "previous": "example",
    "total": 1
  },
  "startDate": "2026-03-11T12:00:00Z",
  "endDate": "2026-03-11T12:00:00Z"
}
```
