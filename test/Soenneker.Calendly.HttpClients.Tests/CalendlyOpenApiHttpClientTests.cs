using Soenneker.Calendly.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Calendly.HttpClients.Tests;

[Collection("Collection")]
public sealed class CalendlyOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ICalendlyOpenApiHttpClient _httpclient;

    public CalendlyOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ICalendlyOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
