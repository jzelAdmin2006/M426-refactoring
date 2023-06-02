namespace Refactoring;

public class Rounding
{
    private readonly double Precision;

    public Rounding(double precision)
    {
        this.Precision = precision;
    }

    public double Round(double value)
    {
        return Math.Round(value / Precision) * Precision;
    }
}
