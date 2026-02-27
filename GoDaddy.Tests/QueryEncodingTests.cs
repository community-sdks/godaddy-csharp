namespace CommunitySdks.GoDaddy.Tests;

public sealed class QueryEncodingTests
{
    [Fact]
    public void BuildQueryPairsRepeatsKeysForArrays()
    {
        var pairs = ApiClient.BuildQueryPairs(new[] { new KeyValuePair<string, object?>("items", new[] { "a", "b" }) });
        Assert.Equal(2, pairs.Count);
        Assert.Equal("items", pairs[0].Key);
        Assert.Equal("a", pairs[0].Value);
        Assert.Equal("items", pairs[1].Key);
        Assert.Equal("b", pairs[1].Value);
    }
}
