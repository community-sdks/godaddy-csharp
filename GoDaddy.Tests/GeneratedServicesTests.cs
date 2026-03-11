using System.Reflection;
using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Http;
using CommunitySdks.GoDaddy.Tests.Support;

namespace CommunitySdks.GoDaddy.Tests;

public sealed class GeneratedServicesTests
{
    [Fact]
    public async Task EveryServiceMethodBuildsARequest()
    {
        var transport = new TestTransport();
        var client = new Client(new Config { ApiKey = "key", ApiSecret = "secret", MaxRetries = 0 }, transport);

        var accessors = typeof(Client)
            .GetMethods(BindingFlags.Instance | BindingFlags.Public)
            .Where(m => m.GetParameters().Length == 0 && m.ReturnType.Name.EndsWith("Service", StringComparison.Ordinal))
            .ToList();

        foreach (var accessor in accessors)
        {
            var service = accessor.Invoke(client, null);
            Assert.NotNull(service);

            var methods = service!.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(m => m.Name.EndsWith("Async", StringComparison.Ordinal))
                .Where(m => m.GetParameters().Length >= 1)
                .Where(m => m.GetParameters()[0].ParameterType.Name.EndsWith("Request", StringComparison.Ordinal))
                .ToList();

            foreach (var method in methods)
            {
                transport.Push(new HttpResponse
                {
                    StatusCode = 200,
                    Headers = new Dictionary<string, string> { ["content-type"] = "application/json" },
                    Body = "{}"
                });

                var before = transport.Requests.Count;
                var requestArg = BuildRequestObject(method.GetParameters()[0].ParameterType);

                var result = method.Invoke(service, new[] { requestArg, CancellationToken.None });
                Assert.NotNull(result);

                var task = Assert.IsAssignableFrom<Task>(result);
                await task;

                var httpRequest = transport.Requests[before];
                Assert.Equal("sso-key key:secret", httpRequest.Headers["Authorization"]);
                Assert.Contains("api.ote-godaddy.com", httpRequest.Url, StringComparison.Ordinal);
            }
        }
    }

    private static object BuildRequestObject(Type requestType)
    {
        var ctor = requestType.GetConstructors().Single();
        var args = ctor.GetParameters().Select(BuildSampleForParameter).ToArray();
        return ctor.Invoke(args);
    }

    private static object? BuildSampleForParameter(ParameterInfo parameter)
    {
        var type = parameter.ParameterType;
        var name = parameter.Name ?? string.Empty;
        var lower = name.ToLowerInvariant();

        var underlying = Nullable.GetUnderlyingType(type);
        if (underlying is not null)
        {
            return BuildSampleValue(underlying, name);
        }

        return BuildSampleValue(type, name);
    }

    private static object BuildSampleValue(Type type, string name)
    {
        var lower = name.ToLowerInvariant();

        if (type == typeof(string))
        {
            if (lower.Contains("domain")) return "example.com";
            if (lower.Contains("ticketid")) return "TCK-100001";
            if (lower.Contains("subscriptionid")) return "sub_12345";
            if (lower.Contains("certificateid")) return "987654";
            if (lower.Contains("customerid") || lower.Contains("shopperid")) return "123456789";
            if (lower.Contains("xappkey")) return "app-key";
            if (lower.Contains("xmarketid")) return "en-US";
            if (lower.Contains("email")) return "admin@example.com";
            return "example";
        }

        if (type == typeof(int))
        {
            if (lower.Contains("offset")) return 0;
            if (lower.Contains("limit")) return 100;
            return 1;
        }

        if (type == typeof(double))
        {
            return 1.0d;
        }

        if (type == typeof(bool))
        {
            return true;
        }

        if (type == typeof(JsonNode))
        {
            return JsonNode.Parse("""{"consent":{"agreedAt":"2026-01-01T00:00:00Z","agreedBy":"127.0.0.1"}}""")!;
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReadOnlyList<>))
        {
            var itemType = type.GetGenericArguments()[0];
            if (itemType == typeof(string)) return new[] { "example" };
            if (itemType == typeof(int)) return new[] { 1, 2 };
            if (itemType == typeof(bool)) return new[] { true };
            if (itemType.IsClass && itemType != typeof(string) && itemType.Namespace is not null && itemType.Namespace.StartsWith("CommunitySdks.GoDaddy.Dto", StringComparison.Ordinal))
            {
                var ctor = itemType.GetConstructors().SingleOrDefault();
                if (ctor is null)
                {
                    throw new InvalidOperationException($"No constructor found for list DTO item type {itemType.FullName}");
                }

                var args = ctor.GetParameters().Select(BuildSampleForParameter).ToArray();
                var instance = ctor.Invoke(args);
                var array = Array.CreateInstance(itemType, 1);
                array.SetValue(instance, 0);
                return array;
            }
        }

        if (type.IsArray)
        {
            var itemType = type.GetElementType() ?? typeof(string);
            if (itemType == typeof(string)) return new[] { "example" };
            if (itemType == typeof(int)) return new[] { 1, 2 };
            if (itemType == typeof(bool)) return new[] { true };
        }

        // DTO-style nested request bodies are created recursively from their constructor.
        if (type.IsClass && type != typeof(string) && type.Namespace is not null && type.Namespace.StartsWith("CommunitySdks.GoDaddy.Dto", StringComparison.Ordinal))
        {
            var ctor = type.GetConstructors().SingleOrDefault();
            if (ctor is null)
            {
                throw new InvalidOperationException($"No constructor found for DTO type {type.FullName}");
            }

            var args = ctor.GetParameters().Select(BuildSampleForParameter).ToArray();
            return ctor.Invoke(args);
        }

        throw new InvalidOperationException($"No sample value mapping for type {type.FullName}");
    }
}
