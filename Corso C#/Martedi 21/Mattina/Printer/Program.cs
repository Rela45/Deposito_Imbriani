#region Interface
public interface ILogger
{
    void Log();
}

#endregion

#region Class concrete
public class ConcreteLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine($"Sto stampando un messaggio correttamente");
        
    }
}
#endregion
#region Class Printer
public class Printer
{
    public ILogger printService { get; set; }

    public void Print()
    {
        if (printService == null)
        {
            Console.WriteLine($"Stampa del messaggio non andata a buon fine");
            return;
        }
        printService.Log();
    }
}

#endregion

#region Main
class Program
{
    static void Main(string[] args)
    {
        var generator = new Printer();
        generator.printService = new ConcreteLogger();  //se commento questo il print non va a buon fine in quanto risulta null.
        generator.Print();
    }
}
#endregion