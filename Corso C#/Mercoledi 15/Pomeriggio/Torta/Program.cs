#region INTERFACE

public interface ITorta
{
    public string Descrizione();
}
#endregion
#region CLASSI CONCRETE BASE
public class TortaCioccolato : ITorta
{
    public string Descrizione()
    {
        return "Torta al cioccolato";
    } 
}

public class TortaVaniglia : ITorta
{
    public string Descrizione()
    {
        return "Torta alla vaniglia";
    }
}
public class TortaFrutta : ITorta
{
    public string Descrizione()
    {
        return "Torta alla frutta";
    }
}

#endregion
#region Decoratore

public abstract class Decoratore : ITorta
{
    protected ITorta baseTorta;
    protected Decoratore(ITorta torta)
    {
        baseTorta = torta;
    }
    public virtual string Descrizione()
    {
        return baseTorta.Descrizione();
    }
}
#endregion
#region Classi Decorator

public class ConPanna : Decoratore
{
    public ConPanna(ITorta torta) : base(torta)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Panna";
    }
}

public class ConFragole : Decoratore
{
    public ConFragole(ITorta torta) : base(torta)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Fragole";
    }
}

public class ConGlassa : Decoratore
{
    public ConGlassa(ITorta torta) : base(torta)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Glassa";
    }
}
#endregion
#region Factory
public static class TortaFactory
{

    public static ITorta CreaTortaBase(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "cioccolato":
                return new TortaCioccolato();
            case "vaniglia":
                return new TortaVaniglia();
            case "frutta":
                return new TortaFrutta();
            default:
                throw new ArgumentException($"Tipo di torta '{tipo}' non riconosciuto.");
        }
    }
}
#endregion


#region MAIN
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine($"Scegli il tipo di torta che vuoi creare");
        string? tipoTorta = Console.ReadLine();
        ITorta torta = TortaFactory.CreaTortaBase(tipoTorta);
        Console.WriteLine(torta.Descrizione());
        
        // TortaFactory nuovaTorta.CreaTortaBase(tipoTorta);   QUESTO NON FUNZIONA DEVO COMPLETARE
        
    }
}
#endregion