internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Calling Api...");
        string response = await SimulateApiCallAsync();

        Console.WriteLine("API Response:");
        Console.WriteLine(response);
    }

    //Async method simulating an api call//
    static async Task<string> SimulateApiCallAsync()
    {
        //Simulate network latency//
        await Task.Delay(2015);

        //Simulate Api response//
        return "User data received successfully";
    }


}
