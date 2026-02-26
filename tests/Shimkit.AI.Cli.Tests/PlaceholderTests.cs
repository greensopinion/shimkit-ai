using Shimkit.AI.Cli;

namespace Shimkit.AI.Cli.Tests;

public class PlaceholderTests
{
    [Fact]
    public void Placeholder_Exists()
    {
        var p = new Placeholder();
        Assert.NotNull(p);
    }
}
