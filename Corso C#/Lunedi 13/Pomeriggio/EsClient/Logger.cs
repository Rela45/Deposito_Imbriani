using System;
namespace EsClient
{
    public sealed class Logger
    {
        private static Logger _istanza;

        private static readonly object _lock = new object();

        private List<string> _logMessages;

        private Logger()
        {
            _logMessages = new List<string>();
        }

        public static Logger GetIstanza()
        {
            if (_istanza is null)
            {
                lock (_lock)
                {
                    if (_istanza is null)
                    {
                        _istanza = new Logger();
                    }
                }
            }
            return _istanza;
        }


        /// <summary>
        /// Aggiunge ad una lista di stringhe il messaggio.
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            _logMessages.Add(message);
        }

        
        /// <summary>
        /// Stampa la lista di logs.
        /// </summary>
        public void PrintLogs()
        {
            Console.WriteLine("Log Messages:");
            foreach (var msg in _logMessages)
            {
                Console.WriteLine("- " + msg);
            }
        }
    }
}