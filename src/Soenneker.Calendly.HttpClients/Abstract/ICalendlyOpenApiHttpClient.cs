using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Calendly.HttpClients.Abstract;

/// <summary>
/// Provides a cached <see cref="HttpClient"/> configured for Calendly's API.
/// </summary>
public interface ICalendlyOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the configured client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
