using System.Diagnostics;
using System.Threading;

DisplayStopWatchResolution();
      
var timer = new Stopwatch();

//begin the test
while (true)
{

    timer.Restart();
    timer.Start();
    //Thread.Sleep(1);
    await Task.Delay(1);
    timer.Stop();
    Console.WriteLine($"Task time {timer.Elapsed.TotalMilliseconds} {Thread.CurrentThread.ManagedThreadId}");
}

static void DisplayStopWatchResolution()
{
    if (Stopwatch.IsHighResolution)
    {
        Console.WriteLine("Operations timed using the system's high-resolution performance counter.");
    }
    else
    {
        Console.WriteLine("Operations timed using the DateTime class.");
    }

    long frequency = Stopwatch.Frequency;
    Console.WriteLine("  Timer frequency in ticks per second = {0}",
        frequency);
    long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
    Console.WriteLine("  Timer is accurate within {0} nanoseconds",
        nanosecPerTick);
}