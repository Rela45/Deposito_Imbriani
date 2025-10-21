public interface INotifier
{
    void Notify(string message);
}

public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Invio email: {message}");
    }
}

public class NotificationService
{
    public void SendNotification(string user, INotifier notifier)
    {
        notifier.Notify($"Ciao {user}, hai una nuova notifica!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotifier notifier = new EmailNotifier();
        var service = new NotificationService();
        service.SendNotification("Luca", notifier);
    }
}