using CommunitySdks.GoDaddy.Errors;
using CommunitySdks.GoDaddy.Http;
using CommunitySdks.GoDaddy.Tests.Support;

namespace CommunitySdks.GoDaddy.Tests;

public sealed class ErrorMappingTests
{
    private static Client CreateClient(TestTransport transport) => new(new Config { ApiKey = "key", ApiSecret = "secret", MaxRetries = 0 }, transport);

    [Fact] public async Task Maps400ToValidationException() { var t = new TestTransport(); t.Push(new HttpResponse { StatusCode = 400, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" }); await Assert.ThrowsAsync<ValidationException>(() => CreateClient(t).Abuse().GetTicketsAsync(null, null, null, null, null, null, null, null)); }
    [Fact] public async Task Maps401ToUnauthorizedException() { var t = new TestTransport(); t.Push(new HttpResponse { StatusCode = 401, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" }); await Assert.ThrowsAsync<UnauthorizedException>(() => CreateClient(t).Abuse().GetTicketsAsync(null, null, null, null, null, null, null, null)); }
    [Fact] public async Task Maps404ToNotFoundException() { var t = new TestTransport(); t.Push(new HttpResponse { StatusCode = 404, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" }); await Assert.ThrowsAsync<NotFoundException>(() => CreateClient(t).Abuse().GetTicketsAsync(null, null, null, null, null, null, null, null)); }
    [Fact] public async Task Maps429ToRateLimitException() { var t = new TestTransport(); t.Push(new HttpResponse { StatusCode = 429, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" }); await Assert.ThrowsAsync<RateLimitException>(() => CreateClient(t).Abuse().GetTicketsAsync(null, null, null, null, null, null, null, null)); }
    [Fact] public async Task Maps500ToServerException() { var t = new TestTransport(); t.Push(new HttpResponse { StatusCode = 500, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" }); await Assert.ThrowsAsync<ServerException>(() => CreateClient(t).Abuse().GetTicketsAsync(null, null, null, null, null, null, null, null)); }
}
