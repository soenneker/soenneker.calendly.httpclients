[![](https://img.shields.io/nuget/v/soenneker.calendly.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calendly.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calendly.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.calendly.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calendly.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.calendly.httpclients/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.calendly.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calendly.httpclients/)

# Soenneker.Calendly.HttpClients

A cached, authenticated `HttpClient` for Calendly's API.

## Installation

```bash
dotnet add package Soenneker.Calendly.HttpClients
```

## Configuration

```json
{
  "Calendly": {
    "ApiKey": "your-personal-access-token"
  }
}
```

`Calendly:ApiKey` is required and is sent as `Authorization: Bearer {token}` by default. For compatible gateways or alternate credentials, `Calendly:ClientBaseUrl`, `Calendly:AuthHeaderName`, and `Calendly:AuthHeaderValueTemplate` can override those defaults. The template must contain `{token}` where the configured value belongs.

## Registration and usage

```csharp
using Soenneker.Calendly.HttpClients.Abstract;
using Soenneker.Calendly.HttpClients.Registrars;

services.AddCalendlyOpenApiHttpClientAsSingleton();

public sealed class CalendlyService(ICalendlyOpenApiHttpClient clientProvider)
{
    public async Task<string> GetCurrentUser(CancellationToken cancellationToken)
    {
        HttpClient client = await clientProvider.Get(cancellationToken);
        return await client.GetStringAsync("users/me", cancellationToken);
    }
}
```

The provider owns its named cache entry. Disposing it removes the entry and disposes the cached client. Prefer singleton registration for normal application-wide use.
