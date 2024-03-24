using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers
{
    public class HashLogger: ILogger
    {

        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public HashLogger (string _name)
        {
            this._name = _name;
            this._logMessages = new ConcurrentDictionary<int, string> ();
        }

        public IDisposable? BeginScope<TState>(TState state)
        {

            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);
            switch (logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine("- LOGGER -");
            var messageToBeLogger = new StringBuilder();
            messageToBeLogger.Append($"[{logLevel}]");
            messageToBeLogger.AppendFormat(" [{0}]", _name);
            Console.WriteLine(messageToBeLogger);
            Console.WriteLine($" {formatter(state, exception)}");
            Console.WriteLine("- LOGGER -");
            Console.ResetColor();
            _logMessages[eventId.Id] = message;
        }
    }



}

