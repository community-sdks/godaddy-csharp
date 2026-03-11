# GoDaddy C# SDK

A community-maintained C# SDK for the provided GoDaddy OpenAPI specs.

## Installation

```sh
dotnet add package CommunitySdks.GoDaddy --version 1.0.2
```

Add the project reference or package to your solution:

```xml
<ItemGroup>
  <ProjectReference Include="..\godaddy-csharp\GoDaddy\GoDaddy.csproj" />
</ItemGroup>
```

## Getting Started

```csharp
using CommunitySdks.GoDaddy;
using CommunitySdks.GoDaddy.Dto.Domains.Requests;

var client = new Client(new Config
{
  BaseUrl = "https://api.ote-godaddy.com",
    ApiKey = "your-api-key",
    ApiSecret = "your-api-secret"
});

var response = await client.Domains().TldsAsync(
  new TldsAsyncRequest()
);

Console.WriteLine(response.Raw?.ToJsonString());
```

## DTO-First Usage

Service methods accept typed request DTOs and return typed response DTO wrappers.

```csharp
using CommunitySdks.GoDaddy.Dto.Abuse.Requests;

var created = await client.Abuse().CreateTicketV2Async(
  new CreateTicketV2AsyncRequest(
    Body: new CreateTicketV2Body(
      Source: "https://malicious.example/phish",
      Type: "PHISHING",
      Target: "Example Bank",
      Useragent: "DESKTOP",
      Proxy: "USA"
    )
  )
);

Console.WriteLine(created.Raw?.ToJsonString());
```

Use `https://api.godaddy.com` for production.

## Services

- [AbuseService](./docs/abuse.md): Abuse reporting and ticket lookup endpoints for phishing, malware, and related investigations.
- [AftermarketService](./docs/aftermarket.md): Aftermarket listing and sales endpoints for secondary-market domain workflows.
- [AgreementsService](./docs/agreements.md): Agreement retrieval endpoints for legal terms and consent workflows.
- [AnsService](./docs/ans.md): Authoritative DNS record and nameserver management endpoints.
- [AuctionsService](./docs/auctions.md): Auction listing discovery endpoints for GoDaddy Auctions inventory.
- [CertificatesService](./docs/certificates.md): SSL certificate purchase, validation, lifecycle, and revocation endpoints.
- [CountriesService](./docs/countries.md): Country and market metadata endpoints used across purchase flows.
- [DomainsService](./docs/domains.md): Domain availability, purchase, management, transfer, and DNS endpoints.
- [OrdersService](./docs/orders.md): Order lookup endpoints for commerce and fulfillment status.
- [ParkingService](./docs/parking.md): Domain parking optimization and template management endpoints.
- [ShoppersService](./docs/shoppers.md): Shopper profile, account, and delegated access endpoints.
- [SubscriptionsService](./docs/subscriptions.md): Subscription listing and management endpoints for recurring products.
