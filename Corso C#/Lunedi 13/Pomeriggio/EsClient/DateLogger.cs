namespace EsClient
{
    public class DateLogger
    {
        private static readonly DateLogger _instance = new DateLogger();
        private List<DateTime> _logs = new List<DateTime>();
        private DateLogger() { }

        public static DateLogger Instance => _instance;

        public void Log(DateTime date) => _logs.Add(date);

        public void PrintLogs()
        {
            Console.WriteLine("Date Logs:");
            foreach (var date in _logs)
                Console.WriteLine("- " + date);
        }
    }
}     