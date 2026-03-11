# AuctionsService

Client accessor: `client.Auctions()`

## Method Index

- [`PlaceBidsAsync`](#placebidsasync)

## Endpoints


### PlaceBidsAsync

Calls `POST /v1/customers/{customerId}/aftermarket/listings/bids`.

```csharp
var response = await client.Auctions().PlaceBidsAsync(
    new PlaceBidsAsyncRequest(
        CustomerId: "123456789",
        RequestBody: new PlaceBidsAsyncRequestRequestBody(

        )
    )
);
```

```json
[
  {
    "listingId": 200000,
    "isHighestBidder": "true",
    "bidId": "e8f0a45d-53c6-49e5-a1f2-08b993960e1b",
    "bidAmountUsd": 100000000,
    "status": "SUCCESS"
  }
]
```
