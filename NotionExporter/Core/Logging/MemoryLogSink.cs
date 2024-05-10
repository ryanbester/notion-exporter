using System.Collections.Concurrent;
using Serilog.Core;
using Serilog.Events;

namespace NotionExporter.Core.Logging
{
    public class MemoryLogSink : ILogEventSink
    {
        public ConcurrentQueue<LogEvent> Events { get; } = new();
        public List<Action<LogEvent>> Watchers { get; } = new();

        public void Emit(LogEvent logEvent)
        {
            Events.Enqueue(logEvent);
            Watchers.ForEach(w => w(logEvent));
        }
    }
}
