#region Singleton
using System.Diagnostics.Contracts;
using System.Dynamic;

public sealed class BankContext
{
    private static  BankContext _instance;
    
    
    private BankContext()
    {
    }
    public static BankContext Instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    public int ClienteID = 1;
    public int ContoID = 100;
    public Dictionary<int, Cliente> Clienti = new();
    public Dictionary<int, IConto> Conti = new();

    public int nuovoConto()
    {
        return ContoID++;
    }

    public int nuovoCliente()
    {
        return ClienteID++;
    }

}
#endregion


#region Cliente
public class Cliente
{
    public int Id { get; }
    public string Nome { get; }
    public string Email { get; }

    public Cliente(int id, string nome, string email)
    {
        Id = id; Nome = nome; Email = email;
    }
}

#endregion

#region Operazioni
public class Operazione
{
    public DateTime Timestamp { get; init; } = DateTime.Now;
    public string Tipo { get; init; } = "";
    public decimal Importo { get; init; }
    public string Descrizione { get; init; } = "";
}

#endregion
#region Interface
public interface IConto
{
    int Id { get; }
    int ClienteId { get; }
    string Tipo { get; }
    decimal Saldo { get; }
    void Deposita(decimal importo);
    bool Preleva(decimal importo);
}
#endregion
#region ConcreteClass
public abstract class Conto : IConto
{
    public int Id { get; }
    public int ClienteId { get; }
    public string Tipo { get; set; }
    public decimal Saldo { get; set; }
    protected Conto(int id, int ClienteId, string Tipo, decimal Saldo = 0m)
    {
        Id = id;
        this.ClienteId = ClienteId;
        this.Tipo = Tipo;
        this.Saldo = Saldo;

    }
    public virtual void Deposita(decimal importo)
    {
        if (importo < 0)
        {
            Console.WriteLine($"l'importo non puo essere minore di 0");
        }
        else
        {
            Saldo += importo;
        }
    }

    public bool Preleva(decimal importo)
    {
        if (importo < 0) return false;
        if (Saldo < importo) return false;
        Saldo -= importo;
        Console.WriteLine($"Importo prelevato");

        return true;
    }
}

public class ContoBase : Conto
{
    public ContoBase(int id, int ClienteId) : base(id, ClienteId, "ContoBase")
    {
    }
}

public class ContoPremium : Conto
{
    public ContoPremium(int id, int ClienteId) : base(id, ClienteId, "Conto Premium")
    {
    }
}

public class ContoStudent : Conto
{
    public ContoStudent(int id, int ClienteId) : base(id, ClienteId, "Conto Student")
    {
    }
}
#endregion
#region Factory
public static class CreaConto
{
    public static IConto Crea(string Tipo, int ClienteId)
    {
        var ctx = BankContext.Instance;
        int id = ctx.nuovoConto();

        Console.WriteLine($"Che tipo di conto vuoi creare? base/premium/studenti");

        switch (Tipo.ToLower())
        {
            case "base":
                return new ContoBase(id, ClienteId);

            case "premium":
                return new ContoPremium(id, ClienteId);
            case "studenti":
                return new ContoStudent(id, ClienteId);

            default:
                throw new ArgumentException("tipo non supportato");
        }
    }
}


#endregion




#region Strategy 
public interface ICalcoloInteressi
{
    decimal CalcolaDeltaInteressi(IConto conto);
    // Commissione per trasferimento (fissa o percentuale, a discrezione)
    decimal CalcolaCommissioneTrasferimento(IConto from, decimal importo);
}


public class StandardStrategy : ICalcoloInteressi
{
    public decimal CalcolaCommissioneTrasferimento(IConto from, decimal importo)
    {
        return 0.50m; //commissione fissa
    }

    public decimal CalcolaDeltaInteressi(IConto conto)
    {
        return Math.Round(conto.Saldo * 0.001m, 2);
    }
}

public class PromoStrategy : ICalcoloInteressi
{
    public decimal CalcolaDeltaInteressi(IConto conto)
    {
        // Base 0.15%, Premium 0.25%, Student 0.20%
        decimal rate = conto.Tipo switch
        {
            "Premium" => 0.0025m,
            "Student" => 0.0020m,
            _ => 0.0015m
        };
        return Math.Round(conto.Saldo * rate, 2);
    }

    public decimal CalcolaCommissioneTrasferimento(IConto from, decimal importo)
    {
        // Nessuna commissione sotto 100 EUR, altrimenti 0.3% minimo 0.20
        if (importo < 100m) return 0m;
        var c = Math.Round(importo * 0.003m, 2);
        return c < 0.20m ? 0.20m : c;
    }
}


#endregion



#region Observer 
public interface IObserver
{
    void Notify();
}

public class Logger : IObserver
{
    public void Notify()
    {
        Console.WriteLine($"[{DateTime.Now:HH:MM:ss}] nuova operazione cominciata");
        
    }
}
public static class BankService
{
    private static BankContext ctx = BankContext.Instance;

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