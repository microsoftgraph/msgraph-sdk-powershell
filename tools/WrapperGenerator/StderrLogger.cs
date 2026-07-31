using System;
using Microsoft.Extensions.Logging;

namespace WrapperGenerator;

// Minimal stderr logger for CLI runs, so the generation service's skip diagnostics (for
// example unsupported OData path shapes) are actually visible without taking a
// console-logging package dependency. Warning and above only: the per-file "Wrote ..."
// chatter stays quiet, and Program prints its own one-line summary.
internal sealed class StderrLogger : ILogger
{
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

    public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Warning;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (IsEnabled(logLevel))
            Console.Error.WriteLine($"[{logLevel}] {formatter(state, exception)}");
    }
}
