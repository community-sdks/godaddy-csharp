# AuctionsService

Auction listing discovery endpoints for GoDaddy Auctions inventory.

## Accessor

```csharp
var service = client.Auctions();
```

## Endpoints

### PlaceBidsAsync

Calls `POST /v1/customers/{customerId}/aftermarket/listings/bids`.

```csharp
var response = await client.Auctions().PlaceBidsAsync("sample", JsonNode.Parse("""{"sample":true}""")!);
```

```json
{}
```

