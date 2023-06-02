namespace Refactoring.Tests;

public class RoundingTest
{
    [Theory]
    [InlineData(1.0, 1.0, 1.0)]
    [InlineData(1.0, 1.1, 1.0)]
    [InlineData(1.0, 1.5, 2.0)]
    [InlineData(1.0, 1.9, 2.0)]
    [InlineData(0.5, 1.0, 1.0)]
    [InlineData(0.5, 1.1, 1.0)]
    [InlineData(0.5, 1.5, 1.5)]
    [InlineData(0.5, 1.9, 2.0)]
    [InlineData(0.1, 1.0, 1.0)]
    [InlineData(0.1, 1.1, 1.1)]
    [InlineData(0.1, 1.5, 1.5)]
    [InlineData(0.1, 1.9, 1.9)]
    [InlineData(0.05, 1.0, 1.0)]
    [InlineData(0.05, 1.1, 1.1)]
    [InlineData(0.05, 1.5, 1.5)]
    [InlineData(0.05, 1.9, 1.9)]
    [InlineData(0.01, 1.0, 1.0)]
    [InlineData(0.01, 1.1, 1.1)]
    [InlineData(0.01, 1.5, 1.5)]
    [InlineData(0.01, 1.9, 1.9)]
    public void Round(double precision, double value, double expected)
    {
        // Arrange
        var rounding = new Rounding(precision);

        // Act
        var actual = rounding.Round(value);

        // Assert
        Assert.Equal(expected, actual, 15);
    }
}
