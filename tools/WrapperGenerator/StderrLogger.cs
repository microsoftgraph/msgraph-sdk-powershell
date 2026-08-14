using System;
using Microsoft.Extensions.Logging;

namespace WrapperGenerator;

// Minimal stderr logger for CLI runs, so the generation service's skip diagnostics (for
// example unsupported OData path shapes) are actually visible without taking a
// console-logging package dependency. Defaults to Warning and above: the per-file "Wrote ..."
// chatter stays quiet, and Program prints its own one-line summary. --log-level lowers the
// threshold to surface the per-property diagnostics the coverage sweep reads.
internal sealed class StderrLogger(LogLevel minimumLevel = LogLevel.Warning) : ILogger
{
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

    public bool IsEnabled(LogLevel logLevel) => logLevel >= minimumLevel;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (IsEnabled(logLevel))
            Console.Error.WriteLine($"[{logLevel}] {formatter(state, exception)}");
    }
}
