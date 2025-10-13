namespace EsClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Otteniamo "due istanze" (che sono in realtà la stessa)
            Logger logger1 = Logger.GetIstanza();
            Logger logger2 = Logger.GetIstanza();

            // Log da "due oggetti diversi"
            logger1.Log("Primo messaggio dal logger1");
            logger2.Log("Secondo messaggio dal logger2");

            // Stampa di tutti i messaggi di log
            logger1.PrintLogs();

            // Verifica che siano effettivamente la stessa istanza
            Console.WriteLine($"logger1 e logger2 sono la stessa istanza? {object.ReferenceEquals(logger1, logger2)}");


            IntLogger.Instance.Log(100);
            IntLogger.Instance.Log(200);

            DateLogger.Instance.Log(DateTime.Now);
            DateLogger.Instance.Log(DateTime.UtcNow);

            IntLogger.Instance.PrintLogs();
            DateLogger.Instance.PrintLogs();


        }
    }
}

