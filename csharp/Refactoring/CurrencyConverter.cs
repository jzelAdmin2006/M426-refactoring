namespace Refactoring;

public class CurrencyConverter
{
    private static Dictionary<string, double> exchangeRates = new()
        {
            { "USD", 1.09 },
            { "EUR", 0.96 },
            { "GBP", 0.82 },
            { "RUB", 79.78 }
        };

    public static double ConvertTo(double amount, string toCurrency)
    {
        if(exchangeRates.ContainsKey(toCurrency))
        {
            return amount * exchangeRates[toCurrency];
        }
        else
        {
            throw new ArgumentException($"no exchange rate for {toCurrency} available");
        }
    }
}
