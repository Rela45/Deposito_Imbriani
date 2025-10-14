using System;


public interface IVeicolo
{
    public void Start();
    public void ShowType();
}

public class ConcreteAuto : IVeicolo
{
    public void Start()
    {
        Console.WriteLine($"Avvio dell'auto");
    }
    public void ShowType()
    {
        Console.WriteLine($"Tipo : auto");
    }
}

public class ConcreteMoto : IVeicolo
{
    public void Start()
    {
        Console.WriteLine($"Avvio della Moto");
    }
    public void ShowType()
    {
        Console.WriteLine($"Tipo : Moto");
    }
}


public class ConcreteCamion : IVeicolo
{
    public void Start()
    {
        Console.WriteLine($"Avvio del camion");
    }
    public void ShowType()
    {
        Console.WriteLine($"Tipo : camion");
    }
}

public class ConcreteNave : IVeicolo
{
    public void Start()
    {
        Console.WriteLine($"Avvio della nave");
    }
    public void ShowType()
    {
        Console.WriteLine($"Tipo : Nave");
    }
}

public abstract class Creator
{

    //Factory
    public abstract IVeicolo CreaVeicolo();

    public void CreazioneVeicolo()
    {

        IVeicolo veicolo = CreaVeicolo();
        if (veicolo != null)
        {
            veicolo.Start();
            veicolo.ShowType();
        }
        else
        {
            Console.WriteLine("Errore: tipo di veicolo non riconosciuto!");
        }
    }

}

public abstract class CreatorNave
{
    public abstract IVeicolo CreaNave();
    public void CreazioneNave()
    {
        IVeicolo nave = CreaNave();
        if (nave != null)
        {
            nave.Start();
            nave.ShowType();
        }
        else
        {
            Console.WriteLine("Errore: tipo di veicolo non riconosciuto!");
        }
    }
}

public class Auto : Creator
{
    public override IVeicolo CreaVeicolo()
    {
        return new ConcreteAuto();
    }
}

public class Moto : Creator
{
    public override IVeicolo CreaVeicolo()
    {
        return new ConcreteMoto();
    }
}

public class Camion : Creator
{
    public override IVeicolo CreaVeicolo()
    {
        return new ConcreteCamion();
    }
}

public class Nave : CreatorNave
{
    public override IVeicolo CreaNave()
    {
        return new ConcreteNave();
    }
}


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Quale veicolo vuoi creare? (auto/moto/camion/nave)");
        string tipo = Console.ReadLine();
        switch (tipo)
        {
            case "auto":
                Auto audi = new Auto();
                audi.CreazioneVeicolo();
                break;
            case "moto":
                Moto kawasaku = new Moto();
                kawasaku.CreazioneVeicolo();
                break;
            case "camion":
                Camion iveco = new Camion();
                iveco.CreazioneVeicolo();
                break;

            case "nave":
                Nave titanic = new Nave();
                titanic.CreazioneNave();
                break;
        }





        Console.WriteLine("\nFine programma. Premi un tasto per uscire.");
        Console.ReadKey();

    }
}