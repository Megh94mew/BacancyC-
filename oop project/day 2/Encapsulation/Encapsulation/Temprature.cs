public class TempratureSensor
{
    private const double AbsoluteZero = -273.18;

    private double _temprature;
    private readonly List<double> _history = new List<double>();

    public double Temprature
    {
        get => _temprature;
        set
        {
            if (value < AbsoluteZero)
            {
                Console.WriteLine("Invalid temprature: below absolute zero.");
                return;
            }

            _temprature = value;
            _history.Add(value);
        }
    }

    public IReadOnlyList<double> TempratureHistory => _history.AsReadOnly();
}