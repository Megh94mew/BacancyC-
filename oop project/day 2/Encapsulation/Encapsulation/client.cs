class Program
{
    static void Main()
    {
        TempratureSensor sensor = new TempratureSensor();

        sensor.Temprature = 20;
        sensor.Temprature = -105;
        sensor.Temprature = -200;

        Console.WriteLine("Current Temprature: " + sensor.Temprature);

        Console.WriteLine("Temprature History:");
        foreach (var temp in  sensor.TempratureHistory)
        {
               Console.WriteLine(temp);
        }
    }
}