namespace CommunitySdks.GoDaddy.Http;

public interface ITransport
{
    Task<HttpResponse> SendAsync(HttpRequest request, CancellationToken cancellationToken = default);
}
