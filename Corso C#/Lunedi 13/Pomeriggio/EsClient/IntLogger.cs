namespace EsClient
{
    public class IntLogger
    {
        private static readonly IntLogger _instance = new IntLogger();
        private List<int> _logs = new List<int>();
        private IntLogger() { }

        public static IntLogger Instance => _instance;

        public void Log(int number) => _logs.Add(number);

        public void PrintLogs()
        {
            Console.WriteLine("Int Logs:");
            foreach (var num in _logs)
                Console.WriteLine("- " + num);
        }
    }

}