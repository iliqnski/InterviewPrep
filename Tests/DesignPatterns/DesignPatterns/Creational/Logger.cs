namespace DesignPatterns.Creational
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Logger
    {
        private static readonly Logger LoggerInstance = new Logger();

        private readonly List<LogEvent> events = new List<LogEvent>();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return LoggerInstance;
            }
        }

        public void SaveToLog(string message)
        {
            this.events.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var ev in this.events)
            {
                Console.WriteLine(ev);
            }
        }
    }

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton()
        {
        }
    }
}
