#region INTERFACE
public interface INotifier
{
    void Notify(string message);
}

public interface ILogger
{
    void Log(string nome);
}

#endregion

//implementazioni delle classi concrete
#region Implementation
public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Invio SMS : {message}");
    }
}

public class SmsLogger : ILogger
{
    public void Log(string nome)
    {
        Console.WriteLine($"LOG {nome} :[{DateTime.Now}]");
    }
}

#endregion


#region Service

public class AlertService
{
    private readonly ILogger _logger;  //variabile per constructor injection
    public AlertService(ILogger logger)  
    {
        _logger = logger;
    }
    public void SendAlert(string message, INotifier notifier) //method injection
    {
        _logger.Log("Alessandro45");    //costructor injection
        notifier.Notify(message);  
    }
}
#endregion

#region MAIN
class Program
{
    static void Main(string[] args)
    {
        INotifier notifier = new SmsNotifier();
        ILogger logger = new SmsLogger();
        var service = new AlertService(logger);
        service.SendAlert("Wanna duoQ?", notifier);

    }
}



#endregion