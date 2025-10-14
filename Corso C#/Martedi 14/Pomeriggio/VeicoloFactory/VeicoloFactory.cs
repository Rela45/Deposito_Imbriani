using System.Runtime.CompilerServices;

public class VeicoloFactory
{
    private static VeicoloFactory _instance;

    private  VeicoloFactory()
    {
        Console.WriteLine($"impedisco la creazione dall'esterno");
    }

    public static IVeicolo CreaVeicolo(string type)
    {
        if (_instance == null)
        {
            _instance = new VeicoloFactory();
        }
        return (IVeicolo)_instance;
    }
}