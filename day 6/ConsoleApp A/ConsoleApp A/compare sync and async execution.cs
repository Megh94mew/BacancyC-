using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Synchronous Execution ===");
        RunSync();

        Console.WriteLine("\n=== Asynchronouse Execution ===");
        await RunAsync();
    }
    // ----------SYNC VERSION----------//
    static void RunSync()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        SimulateApiCallSync();
        SimulateApiCallSync();
        SimulateApiCallSync();

        stopwatch.Stop();
        Console.WriteLine($"Sync TotalTime: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void SimulateApiCallSync()
    {
        //Blocks the thread for 5 seconds//
        Thread.Sleep(2000);
    }

    // ------------ASYNC VERSION----------//
    static async Task RunAsync()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Task t1 = SimulateApiCallAsync();
        Task t2 = SimulateApiCallAsync();
        Task t3 = SimulateApiCallAsync();

        await Task.WhenAll(t1, t2, t3);

        stopwatch.Stop();
        Console.WriteLine($"Async Total Time: {stopwatch.ElapsedMilliseconds} ms");
    }
    static async Task SimulateApiCallAsync()
    {
        // Non-blocking delay for 5seconds//
        await Task.Delay(2000);
    }
}

