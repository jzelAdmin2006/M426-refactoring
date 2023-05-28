namespace Refactoring;

public class Rounding
{
    public double Precision { get; }

    public Rounding(double precision)
    {
        this.Precision = precision;
    }

    public double Round(double value)
    {
        switch (Precision)
        {
            case 1.0:
                return Math.Round(value);
            case 0.5:
                return Math.Round(value * 2.0) / 2.0;
            case 0.1:
                return Math.Round(value * 10.0) / 10.0;
            case 0.05:
                return Math.Round(value * 20.0) / 20.0;
            case 0.01:
                return Math.Round(value * 100.0) / 100.0;
            default:
                throw new ArgumentException($"unable to round to a precision of {Precision}");
        }
    }
}
