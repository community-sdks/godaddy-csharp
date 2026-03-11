# CountriesService

Client accessor: `client.Countries()`

## Method Index

- [`GetCountriesAsync`](#getcountriesasync)
- [`GetCountryAsync`](#getcountryasync)

## Endpoints

### GetCountriesAsync

Calls `GET /v1/countries`.

```csharp
var response = await client.Countries().GetCountriesAsync(
    new GetCountriesAsyncRequest(
        MarketId: "example"
    )
);
```

```json
[
  {
    "callingCode": "example",
    "countryKey": "example",
    "label": "example"
  }
]
```

### GetCountryAsync

Calls `GET /v1/countries/{countryKey}`.

```csharp
var response = await client.Countries().GetCountryAsync(
    new GetCountryAsyncRequest(
        CountryKey: "example",
        MarketId: "example"
    )
);
```

```json
[
  {
    "callingCode": "example",
    "countryKey": "example",
    "label": "example",
    "states": [
      {}
    ]
  }
]
```
