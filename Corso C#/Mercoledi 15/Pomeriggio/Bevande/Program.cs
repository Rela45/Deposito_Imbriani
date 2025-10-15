#region INTERFACES
using System.Dynamic;

public interface IBevanda
{
    void Descrizione();
    double Costo();
}
#endregion
#region classi concrete
public class Caffe : IBevanda
{
    private double _costo;
    public Caffe(double costo)
    {
        _costo = costo;
    }
    public double Costo()
    {
        return _costo;
    }

    public void Descrizione()
    {
        Console.WriteLine($"Caffe corto");

    }
}

public class The : IBevanda
{
    private double _costo;
    public double Costo()
    {
        return _costo;
    }
    public void Descrizione()
    {
        Console.WriteLine($"The");

    }
}
#endregion
#region decorator
public abstract class Decorator : IBevanda
{
    protected IBevanda _bevanda;
    protected Decorator(IBevanda bevanda)
    {
        _bevanda = bevanda;
    }
    public virtual double Costo()
    {
        return _bevanda.Costo();
    }

    public virtual void Descrizione()
    {
        _bevanda.Descrizione();
        Console.WriteLine($"Con:");
        
    }
}
#endregion
#region classi decorator
public class ConLatte : Decorator
{
    private double _costo;
    public ConLatte(IBevanda bevanda, double costo) : base(bevanda)
    {
        _costo = costo;
    }

    public override double Costo()
    {
        Console.WriteLine($"Costo caffe normale {_costo}");
        Console.WriteLine($"Costo con Latte :");
        return base.Costo();
    }
    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Latte");
    }
}

public class ConCioccolato : Decorator
{
    private double _costo;
    public ConCioccolato(IBevanda bevanda, double costo) : base(bevanda)
    {
        _costo = costo;
    }

    public override double Costo()
    {
        Console.WriteLine($"Costo caffe normale {_costo}");
        
        return base.Costo();
    }
    public override void Descrizione()
    {
        Console.WriteLine($"Cioccolato");
        base.Descrizione();
    }
}

public class ConPanna : Decorator
{
    private double _costo;
    public ConPanna(IBevanda bevanda, double costo) : base(bevanda)
    {
        _costo = costo;
    }

    public override double Costo()
    {
        Console.WriteLine($"Costo caffe normale {_costo}");
        Console.WriteLine($"Costo con Panna :");
        return base.Costo();
    }
    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Panna");
    }
}



#endregion


#region MAIN
internal class Program
{
    public static void Main(string[] args)
    {
        IBevanda bevanda = new Caffe(2);
        bevanda.Costo();
        bevanda.Descrizione();

        IBevanda decorator1 = new ConCioccolato(bevanda, 2);
        decorator1.Descrizione();
        decorator1.Costo();

        double costototale = bevanda.Costo() + decorator1.Costo();
        Console.WriteLine($"Costo Totale : {costototale}");
        
    }
}
#endregion