
#region Singleton
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public sealed class AppContext
{
    private static AppContext _instance;

    private AppContext() { }

    public static AppContext GetInstance()
    {
        if (_instance == null)
        { _instance = new AppContext(); }
        return _instance;
    }

    public string Valuta(string valuta)
    {
        return valuta;
    }

    public int Iva(int iva)
    {
        return iva;
    }

    public double ScontiDiBase(double scontiDiBase)
    {
        return scontiDiBase;
    }

    public void ScriviMessaggio(string messaggio)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"[{timestamp}]{messaggio}");
    }
}

#endregion


#region Factory
public interface IProductCode
{
    string ProductCode();
}

public class Tshirt : IProductCode
{
    public string ProductCode()
    {
        return "TSHIRT";
    }
}

public class Mug : IProductCode
{
    public string ProductCode()
    {
        return "MUG";
    }
}

public class Skin : IProductCode
{
    public string ProductCode()
    {
        return "SKIN";
    }
}

public abstract class ProductFactory 
{
    public static IProductCode CreateProduct(string productCode)
    {
        switch (productCode)
        {
            case "TSHIRT":
                return new Tshirt();
            case "MUG":
                return new Mug();
            case "SKIN":
                return new Skin();
            default:
                return null;  
        }
    }
}
#endregion


#region Decorator
public interface IAddon
{
    string Descrizione();
}

public abstract class Decorator : IAddon
{
    public virtual string Descrizione()
    {
        return Descrizione();
    }
}

public class StampaFronteRetro : Decorator
{
    public override string Descrizione()
    {
        return base.Descrizione() + "Stampa Fronte/retro";
    }
}

public class ConfezioneRegalo : Decorator
{
    public override string Descrizione()
    {
        return base.Descrizione() + "In confezione regalo";
    }
}

public class EstensioneGaranziaDigitale : Decorator
{
    public override string Descrizione()
    {
        return base.Descrizione() + "Garanzia estesa";
    }
}

#endregion


#region Strategy
public interface IPricingStrategy
{
    double Price(double price);
}

public class StandardPricing : IPricingStrategy
{
    public double Price(double price)
    {
        return price;
    }
}

public class PromoPricing : IPricingStrategy
{
    public double Price(double price)
    {
        return price * 0.20;
    }
}

public class WholesalePricing : IPricingStrategy
{
    public double Price(double price)
    {
        return price * 0.3;
    }
}


public class DynamicPricing : IPricingStrategy
{
    public double Price(double price)
    {
        Random sconto = new Random();
        var rndSconto = 0.2 + sconto.NextDouble();
        return price * rndSconto;
    }
}


public class ProductPrice
{
    private IPricingStrategy _strategy;

    public void SetStrategy(IPricingStrategy strategy)
    {
        _strategy = strategy;
    }
    public double Price(double price)
    {
        return _strategy.Price(price);
    }
}

#endregion


#region Observer
public interface IOrderObserver
{
    void OnOrderChanged(string message);
}

public class EventBus
{
    private readonly List<IOrderObserver> _subscribers = new();

    public void Subscribe(IOrderObserver observer) => _subscribers.Add(observer);
    public void Unsubscribe(IOrderObserver observer) => _subscribers.Remove(observer);

    public void Notify(string message)
    {
        foreach (var obs in _subscribers)
            obs.OnOrderChanged(message);
    }
}

public class UILogger : IOrderObserver
{
    public void OnOrderChanged(string message) => Console.WriteLine("[UI] " + message);
}

public class EmailMock : IOrderObserver
{
    public void OnOrderChanged(string message) => Console.WriteLine("[EMAIL] Notifica: " + message);
}


#endregion

#region MAIN
internal class Program
{
    private static void Main(string[] args)
    {
        var Product = AppContext.GetInstance();

        

    }
}
#endregion