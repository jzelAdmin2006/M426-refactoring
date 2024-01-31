namespace Refactoring.Tests;

public class CurrencyConverterTest
{
    [Theory]
    [InlineData(100.0, "USD", 109.0)]
    [InlineData(100.0, "EUR", 96.0)]
    [InlineData(100.0, "GBP", 82.0)]
    [InlineData(100.0, "RUB", 7978.0)]
    public void ConvertTo_WithValidCurrency_ReturnsConvertedAmount(int amount, string toCurrency, int expected)
    {
        // Act
        var actual = CurrencyConverter.ConvertTo(amount, toCurrency);

        // Assert
        Assert.Equal(expected, Math.Round(actual, 2));
    }

    [Fact]
    public void ConvertTo_WithInvalidCurrency_ThrowsArgumentException()
    {
        // Arrange
        var amount = 100.0;
        var toCurrency = "XYZ";

        // Act
        var exception = Record.Exception(() => CurrencyConverter.ConvertTo(amount, toCurrency));

        // Assert
        Assert.IsType<ArgumentException>(exception);
        Assert.Equal($"no exchange rate for XYZ available", exception.Message);
    }
}
