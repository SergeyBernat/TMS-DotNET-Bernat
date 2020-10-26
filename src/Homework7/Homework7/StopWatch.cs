using System;
using System.Timers;

public class StopWatch
{
    private static Timer aTimer;

    public static void SetTimer()
    {
        aTimer = new Timer(1000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;

        Console.ReadLine();
    }
    private static void OnTimedEvent(object timer, ElapsedEventArgs e) => Console.WriteLine("{0:HH:mm:ss}", e.SignalTime);
}