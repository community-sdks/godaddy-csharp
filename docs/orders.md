# OrdersService

Client accessor: `client.Orders()`

## Method Index

- [`ListAsync`](#listasync)
- [`GetAsync`](#getasync)

## Endpoints

### ListAsync

Calls `GET /v1/orders`.

```csharp
var response = await client.Orders().ListAsync(
    new ListAsyncRequest(
        PeriodStart: "example",
        PeriodEnd: "example",
        Domain: "example.com",
        ProductGroupId: 1,
        PaymentProfileId: 1,
        ParentOrderId: "ORD-12345",
        Offset: 0,
        Limit: 100,
        Sort: "example",
        XShopperId: "123456789",
        XAppKey: "app-key"
    )
);
```

```json
{
  "orders": [
    {
      "createdAt": "2026-03-11T12:00:00Z",
      "currency": "example",
      "items": [
        {}
      ],
      "orderId": "example",
      "parentOrderId": "example",
      "pricing": {}
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

### GetAsync

Calls `GET /v1/orders/{orderId}`.

```csharp
var response = await client.Orders().GetAsync(
    new GetAsyncRequest(
        OrderId: "ORD-12345",
        XShopperId: "123456789",
        XMarketId: "en-US",
        XAppKey: "app-key"
    )
);
```

```json
{
  "billTo": {
    "contact": {
      "addressMailing": {},
      "email": {},
      "fax": {},
      "jobTitle": {},
      "nameFirst": {},
      "nameLast": {},
      "nameMiddle": {},
      "organization": {},
      "phone": {}
    },
    "taxId": "example"
  },
  "createdAt": "2026-03-11T12:00:00Z",
  "currency": "example",
  "items": [
    {
      "domains": [
        {}
      ],
      "label": "example",
      "period": 1,
      "periodUnit": "MONTH",
      "pfid": 1,
      "pricing": {},
      "quantity": 1,
      "taxCollector": {}
    }
  ],
  "orderId": "example",
  "parentOrderId": "example",
  "payments": [
    {
      "amount": 1,
      "category": "CREDIT_CARD",
      "paymentProfileId": "example",
      "subcategory": "CHECKING_PERSONAL"
    }
  ],
  "pricing": {
    "discount": 1,
    "fees": {
      "icann": {},
      "total": {}
    },
    "id": 1,
    "list": 1,
    "savings": 1,
    "subtotal": 1,
    "taxes": 1,
    "taxDetails": [
      {}
    ],
    "total": 1
  }
}
```
