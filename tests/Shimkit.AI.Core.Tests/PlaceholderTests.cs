using Shimkit.AI.Core;

namespace Shimkit.AI.Core.Tests;

public class PlaceholderTests
{
    [Fact]
    public void Placeholder_Exists()
    {
        var p = new Placeholder();
        Assert.NotNull(p);
    }
}
