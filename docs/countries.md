# CountriesService

Country and market metadata endpoints used across purchase flows.

## Accessor

```csharp
var service = client.Countries();
```

## Endpoints

### GetCountriesAsync

Calls `GET /v1/countries`.

```csharp
var response = await client.Countries().GetCountriesAsync("sample");
```

```json
{}
```

### GetCountryAsync

Calls `GET /v1/countries/{countryKey}`.

```csharp
var response = await client.Countries().GetCountryAsync("sample", "sample");
```

```json
{}
```

