using CommunitySdks.GoDaddy.Http;

namespace CommunitySdks.GoDaddy.Tests.Support;

public sealed class TestTransport : ITransport
{
    public List<HttpRequest> Requests { get; } = new();
    private readonly Queue<HttpResponse> _responses = new();

    public void Push(HttpResponse response) => _responses.Enqueue(response);

    public Task<HttpResponse> SendAsync(HttpRequest request, CancellationToken cancellationToken = default)
    {
        Requests.Add(request);
        return Task.FromResult(_responses.Count > 0 ? _responses.Dequeue() : new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { ["content-type"] = "application/json" }, Body = "{}" });
    }
}
