#region INTERFACE
using System.Runtime.CompilerServices;
public interface IPreparazioneStrategia
{
    string Prepara(string descrizione);
}
public interface IPiatto
{
    string Descrizione();
    string Prepara();
}
#endregion
#region Classi Base
public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return "pizza";
    }
    public string Prepara()
    {
        return "come da strategia";
    }
}

public class Hamburger : IPiatto
{
    public string Descrizione()
    {
        return "Hamburger";
    }
    public string Prepara()
    {
        return "come da strategia";
    }
}

public class Insalata : IPiatto
{
    public string Descrizione()
    {
        return "Insalata";
    }
    public string Prepara()
    {
        return "come da strategia";
    }
}

#endregion

#region Decorator
public abstract class Decorator : IPiatto
{
    protected IPiatto _piattoBase;
    protected Decorator(IPiatto piattoBase)
    {
        _piattoBase = piattoBase;
    }
    public virtual string Descrizione()
    {
        return _piattoBase.Descrizione();
    }
}
#endregion

#region ClassiDecorator


public class ConFormaggio : Decorator
{
    public ConFormaggio(IPiatto piattoBase) : base(piattoBase)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Formaggio";
    }
}

public class ConBacon : Decorator
{
    public ConBacon(IPiatto piattoBase) : base(piattoBase)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Bacon";
    }
}

public class ConSalsa : Decorator
{
    public ConSalsa(IPiatto piattoBase) : base(piattoBase)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "Con Salsa";
    }
}
#endregion
#region Factory
public static class PiattoFactory
{
    public static IPiatto Crea(string tipo)
    {
        switch (tipo)
        {
            case "Pizza":
                return new Pizza();
            case "Hamburger":
                return new Hamburger();
            case "Insalata":
                return new Insalata();
            default:
                return null;    
        }
    }
}
#endregion
#region Strategy
public class Fritto : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "Fritto";
    }
}

public class AlForno : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "AlForno";
    }
}

public class AllaGriglia : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "Alla Griglia";
    }
}
#endregion
#region Chef
public class Chef
{
    private IPreparazioneStrategia _preparazione;

    public void ImpostaStrategia(IPreparazioneStrategia preparazione)
    {
        _preparazione = preparazione;
    }
    public void PreparaPiatto(string piatto)
    {
        _preparazione.Prepara(piatto);
    }
}

#endregion
#region MAIN


class Program
{
    static void Main(string[] args)
    {

    }
}

#endregion