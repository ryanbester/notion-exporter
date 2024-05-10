using Microsoft.Extensions.Logging;
using NotionExporter.Data.Settings;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace NotionExporter.Core.Logging;

public static class Logger
{
    public static ILoggerFactory? Factory { get; private set; }
    public static ILogger? App { get; private set; }
    public static MemoryLogSink MemorySink { get; } = new();

    public static void InitLogger()
    {
        var serilog = new LoggerConfiguration()
            .MinimumLevel.Is(SettingsManager.Settings.LogLevel)
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .WriteTo.Sink(MemorySink)
            .CreateLogger();

        Factory = new LoggerFactory().AddSerilog(serilog);
        App = Factory.CreateLogger("NotionExporter");
    }
}
