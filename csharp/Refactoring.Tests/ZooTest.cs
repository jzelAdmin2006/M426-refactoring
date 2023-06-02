using Refactoring.Animals;
using Xunit;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void TestMakeNoise()
    {
        // Arrange
        var cow = new Cow("Betsy");
        var dog = new Dog("Fido");
        var horse = new Horse("Mr. Ed");

        // Act
        var cowNoise = Zoo.MakeNoise(cow);
        var dogNoise = Zoo.MakeNoise(dog);
        var horseNoise = Zoo.MakeNoise(horse);

        // Assert
        Assert.Equal("Betsy says 'mooh'", cowNoise);
        Assert.Equal("Fido says 'woof'", dogNoise);
        Assert.Equal("Mr. Ed says 'neigh'", horseNoise);
    }
}
