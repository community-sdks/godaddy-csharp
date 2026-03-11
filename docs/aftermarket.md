# AftermarketService

Client accessor: `client.Aftermarket()`

## Method Index

- [`GetListingsAsync`](#getlistingsasync)
- [`DeleteListingsAsync`](#deletelistingsasync)
- [`AddExpiryListingsAsync`](#addexpirylistingsasync)

## Endpoints


### GetListingsAsync

Calls `GET /v1/customers/{customerId}/auctions/listings`.

```csharp
var response = await client.Aftermarket().GetListingsAsync(
    new GetListingsAsyncRequest(
        CustomerId: "123456789",
        Domains: "example.com",
        ListingStatus: "example",
        TransferBefore: "example",
        TransferAfter: "example",
        Limit: 100,
        Offset: 0
    )
);
```

```json
{
  "listings": [
    {
      "listingId": 1,
      "domainName": "example",
      "domainCreatedAt": "2026-03-11T12:00:00Z",
      "domainExpiresAt": "2026-03-11T12:00:00Z",
      "domainRegistrarIanaId": 1,
      "pageViewsMonthly": 1,
      "revenueMonthly": 1,
      "auctionStartAt": "2026-03-11T12:00:00Z",
      "auctionEndAt": "2026-03-11T12:00:00Z",
      "auctionTransferAt": "2026-03-11T12:00:00Z",
      "auctionSoldAt": "2026-03-11T12:00:00Z",
      "auctionBookingAmountUsd": 1,
      "createdAt": "2026-03-11T12:00:00Z",
      "updatedAt": "2026-03-11T12:00:00Z"
    }
  ],
  "pagination": {
    "first": "example",
    "previous": "example",
    "next": "example",
    "last": "example",
    "total": 1
  }
}
```

### DeleteListingsAsync

Calls `DELETE /v1/aftermarket/listings`.

```csharp
var response = await client.Aftermarket().DeleteListingsAsync(
    new DeleteListingsAsyncRequest(
        Domains: new[] { "example.com", "example.net" }
    )
);
```

```json
{
  "listingActionId": 1
}
```

### AddExpiryListingsAsync

Calls `POST /v1/aftermarket/listings/expiry`.

```csharp
var response = await client.Aftermarket().AddExpiryListingsAsync(
    new AddExpiryListingsAsyncRequest(
        ExpiryListings: new AddExpiryListingsAsyncRequestExpiryListings(

        )
    )
);
```

```json
{
  "listingActionId": 1
}
```
