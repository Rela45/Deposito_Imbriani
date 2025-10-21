using System.Text.RegularExpressions;

public interface IDatabaseService
{
    void Connect();
}

public class SqlDatabase : IDatabaseService
{
    public void Connect()
    {
        Console.WriteLine($"Connessione al database SQL stabilita");
    }
}

public class ReportGenerator
{
    public IDatabaseService databaseService { get; set; }

    public void GenerateReport()
    {
        if (databaseService == null)
        {
            Console.WriteLine($"DatabaseService non impostato");
            return;
        }
        databaseService.Connect();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var generator = new ReportGenerator();
        generator.databaseService = new SqlDatabase();   //se viene commentata questa linea, non viene inettata in datatbaseService la dipendenze e risulta null.
        generator.GenerateReport();
    }
}