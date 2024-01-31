using Xunit;

namespace Refactoring.Tests;

public class FamilyMemberTest
{
    [Fact]
    public void TestDescendantsOfThreeGenerationsBackAreListed()
    {
        // Arrange
        FamilyMember a = new("a");
        FamilyMember b = new("b", new() { a });
        FamilyMember c = new("c", new() { b });
        FamilyMember d = new("d", new() { c });

        // Act
        var descendants = d.GetDescendants(0);

        // Assert
        Assert.True(descendants.ContainsKey(a));
        Assert.True(descendants.ContainsKey(b));
        Assert.True(descendants.ContainsKey(c));
    }

    [Fact]
    public void TestDescendantsOfThreeGenerationsHaveCorrectGeneration()
    {
        // Arrange
        FamilyMember a = new("a");
        FamilyMember b = new("b", new() { a });
        FamilyMember c = new("c", new() { b });
        FamilyMember d = new("d", new() { c });

        // Act
        var descendants = d.GetDescendants(0);

        // Assert
        Assert.Equal(3, descendants[a]);
        Assert.Equal(2, descendants[b]);
        Assert.Equal(1, descendants[c]);
    }

    [Fact]
    public void TestDescendantsOfNGenerationsHaveCorrectGeneration()
    {
        // Arrange
        FamilyMember a = new("a");
        FamilyMember b = new("b", new() { a });
        FamilyMember c = new("c", new() { b });
        FamilyMember d = new("d", new() { c });
        FamilyMember e = new("e", new() { d });
        FamilyMember f = new("f", new() { e });
        FamilyMember g = new("g", new() { f });

        // Act
        var descendants = g.GetDescendants(0);

        // Assert
        Assert.Equal(6, descendants[a]);
        Assert.Equal(5, descendants[b]);
        Assert.Equal(4, descendants[c]);
        Assert.Equal(3, descendants[d]);
        Assert.Equal(2, descendants[e]);
        Assert.Equal(1, descendants[f]);
    }
}
