using System.Diagnostics;

namespace euler; 

public static class Timer {
    private static Stopwatch stopwatch = new();
    public static void startTimer() => stopwatch.Start();
    public static void stopTimer() => stopwatch.Stop();
    public static TimeSpan Elapsed() => stopwatch.Elapsed;
}