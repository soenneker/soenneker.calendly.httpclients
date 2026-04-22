using Soenneker.Calendly.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Calendly.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CalendlyOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ICalendlyOpenApiHttpClient _httpclient;

    public CalendlyOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ICalendlyOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
