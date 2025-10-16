#region INTERFACE
public interface IStrategiaOperazione
{
    double Calcola(double a, double b);
}
#endregion
#region ConcreteStrategy
public class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}



public class SottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

public class MoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a / b;
    }
}

#endregion

#region Context
public class Calcolatrice
{
    private IStrategiaOperazione _strategiaOperazione;



    public void ImpostaStrategia(IStrategiaOperazione strategiaOperazione)
    {

        _strategiaOperazione = strategiaOperazione;
    }
    
    public void EseguiOperazione(double a, double b)
    {
        if (_strategiaOperazione == null)
        {
            Console.WriteLine($"Nessuna operazione scelta");
            return;
        }
        double result = _strategiaOperazione.Calcola(a, b);
        Console.WriteLine($"Risultato dell'operazione : {result}");
        
    }
}


#endregion
#region Utente
public sealed class Utente
{
    private static Utente _instance;
    private Utente()
    {
    }

    public static Utente Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Utente();
            }
            return _instance;
        }
    }
}
#endregion
#region MAIN
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine($"Inserisci 2 numeri");
        Utils.ReadLine(out double a);
        Utils.ReadLine(out double b);

        var context = new Calcolatrice();

        Console.WriteLine($"Scegli l'operazione");
        Utils.ReadLine(out string operazione);

        switch (operazione)
        {
            case "addizione":
                context.ImpostaStrategia(new SommaStrategia());
                context.EseguiOperazione(a, b);
                break;

            case "sottrazione":
                context.ImpostaStrategia(new SottrazioneStrategia());
                context.EseguiOperazione(a, b);
                break;
            case "moltiplicazione":
                context.ImpostaStrategia(new MoltiplicazioneStrategia());
                context.EseguiOperazione(a, b);
                break;

            case "divisione":
                context.ImpostaStrategia(new DivisioneStrategia());
                context.EseguiOperazione(a, b);
                break;
            default:
                Console.WriteLine($"Operazione scelta non supportata");
                break;
        }



    }
}

#endregion