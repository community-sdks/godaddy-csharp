# SubscriptionsService

Client accessor: `client.Subscriptions()`

## Method Index

- [`ListAsync`](#listasync)
- [`ProductGroupsAsync`](#productgroupsasync)
- [`CancelAsync`](#cancelasync)
- [`GetAsync`](#getasync)
- [`UpdateAsync`](#updateasync)

## Endpoints


### ListAsync

Calls `GET /v1/subscriptions`.

```csharp
var response = await client.Subscriptions().ListAsync(
    new ListAsyncRequest(
        XAppKey: "app-key",
        XShopperId: "123456789",
        XMarketId: "en-US",
        ProductGroupKeys: new[] { "value" },
        Includes: new[] { "contacts", "privacy" },
        Offset: 0,
        Limit: 100,
        Sort: "example"
    )
);
```

```json
{
  "pagination": {
    "first": "example",
    "last": "example",
    "next": "example",
    "previous": "example",
    "total": 1
  },
  "subscriptions": [
    {
      "addons": [
        {}
      ],
      "billing": {},
      "cancelable": false,
      "createdAt": "2026-03-11T12:00:00Z",
      "expiresAt": "2026-03-11T12:00:00Z",
      "label": "example",
      "launchUrl": "example",
      "paymentProfileId": 1,
      "priceLocked": false,
      "product": {},
      "relations": {},
      "renewAuto": false,
      "renewable": false,
      "status": "ACTIVE",
      "subscriptionId": "example",
      "upgradeable": false
    }
  ]
}
```

### ProductGroupsAsync

Calls `GET /v1/subscriptions/productGroups`.

```csharp
var response = await client.Subscriptions().ProductGroupsAsync(
    new ProductGroupsAsyncRequest(
        XAppKey: "app-key",
        XShopperId: "123456789"
    )
);
```

```json
[
  {
    "productGroupKey": "example",
    "subscriptionCount": 1
  }
]
```

### CancelAsync

Calls `DELETE /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().CancelAsync(
    new CancelAsyncRequest(
        XAppKey: "app-key",
        XShopperId: "123456789",
        SubscriptionId: "sub_12345"
    )
);
```

```json
{
  "status": "ok"
}
```

### GetAsync

Calls `GET /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().GetAsync(
    new GetAsyncRequest(
        XAppKey: "app-key",
        XShopperId: "123456789",
        SubscriptionId: "sub_12345"
    )
);
```

```json
{
  "addons": [
    {
      "commitment": "PAID",
      "pfid": 1,
      "quantity": 1
    }
  ],
  "billing": {
    "commitment": "PAID",
    "pastDueTypes": [
      "ADDON"
    ],
    "renewAt": "2026-03-11T12:00:00Z",
    "status": "CURRENT"
  },
  "cancelable": false,
  "createdAt": "2026-03-11T12:00:00Z",
  "expiresAt": "2026-03-11T12:00:00Z",
  "label": "example",
  "launchUrl": "example",
  "paymentProfileId": 1,
  "priceLocked": false,
  "product": {
    "label": "example",
    "namespace": "example",
    "pfid": 1,
    "productGroupKey": "example",
    "renewalPeriod": 1,
    "renewalPeriodUnit": "MONTH",
    "renewalPfid": 1,
    "supportBillOn": false
  },
  "relations": {
    "children": [
      "example"
    ],
    "parent": "example"
  },
  "renewAuto": false,
  "renewable": false,
  "status": "ACTIVE",
  "subscriptionId": "example",
  "upgradeable": false
}
```

### UpdateAsync

Calls `PATCH /v1/subscriptions/{subscriptionId}`.

```csharp
var response = await client.Subscriptions().UpdateAsync(
    new UpdateAsyncRequest(
        XAppKey: "app-key",
        XShopperId: "123456789",
        SubscriptionId: "sub_12345",
        Subscription: new UpdateAsyncRequestSubscription(
            PaymentProfileId: 1,
            RenewAuto: true
        )
    )
);
```

```json
{
  "status": "ok"
}
```
