#region Singleton
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public sealed class BankContext
{
    private static readonly Lazy<BankContext> _lazy = new(() => new BankContext());
    public static BankContext Instance => _lazy.Value;
    private readonly List<IObserver> _observer = new();
    public ICalcoloInteressi Strategy { get; private set; } = new StandardStrategy();
    private BankContext()
    {
    }

    public int ClienteID = 1;
    public int ContoID = 100;

    public Dictionary<int, Cliente> Clienti = new();
    public Dictionary<int, IConto> Conti = new();

    public Dictionary<int, List<Operazione>> operazioni = new();

    public void SetStrategy(ICalcoloInteressi strategy)
    {
        Strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        Notify("nuova strategia settata");
    }

    public int nuovoConto()
    {
        return ContoID++;
    }

    public int nuovoCliente()
    {
        return ClienteID++;
    }

    public void Subscribe(IObserver obs)
    {
        if (obs == null) return;
        _observer.Add(obs);
    }

    public void Notify(string messaggio)
    {
        foreach(var obv in _observer)
        {
            obv.Notify(messaggio);
        }
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
    protected Conto(int id, int clienteId, string Tipo, decimal Saldo = 0m)
    {
        Id = id;
        this.ClienteId = clienteId;
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

    public virtual  bool Preleva(decimal importo)
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
public static class ContoFactory
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
    void Notify(string messaggio);
}

public class Logger : IObserver
{
    public void Notify(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now:HH:MM:ss}] {messaggio}"); 
    }
}
public class BankService
{
    private static BankContext ctx = BankContext.Instance;


    public static Cliente CreaCliente(string nome, string email)
    {
        int id = ctx.nuovoCliente();
        var cliente = new Cliente(id, nome, email);
        ctx.Clienti.Add(id, cliente);  //vado ad inserire nel "database" (dictionary) il nuovo cliente creato
        ctx.Notify("nuovo cliente creato");
        return cliente;
    }

    public static IConto CreaConto(int clienteId, string tipo)
    {
        if (!ctx.Clienti.ContainsKey(clienteId))
        {
            throw new ArgumentException("Cliente inesistente");
        }

        var conto = ContoFactory.Crea(tipo, clienteId);
        ctx.Conti.Add(conto.Id, conto);
        ctx.Notify("nuovo conto creato");
        return conto;
    }

    private static void AggiungiOperazione(int contoId, string tipo, decimal importo, string descrizione)
    {
        ctx.operazioni[contoId].Add(new Operazione
        {
            Tipo = tipo,
            Importo = importo,
            Descrizione = descrizione
        });
    }

    public static void Deposita(int contoId, decimal importo)
    {
        if (!ctx.Conti.TryGetValue(contoId, out var conto))
        {
            throw new ArgumentException("Conto inesistente");
        }
        conto.Deposita(importo);
        AggiungiOperazione(contoId, "Deposito", importo, "contanti");
        ctx.Notify($"Depositati {importo} in contanti");
    }
    
    public static bool Preleva(int contoId, decimal importo)
    {
        if (!ctx.Conti.TryGetValue(contoId, out var conto))
        {
            throw new ArgumentException("Conto inesistente");
        }

        bool ok = conto.Preleva(importo);
        if (ok)
        {
            AggiungiOperazione(contoId, "Preleva", importo, "contanti");
            ctx.Notify("Contanti prelevati correttamente");
        }
        else
        {
            ctx.Notify("Prelievo rifiutato, saldo non sufficente");
        }

        return ok; 

    }
    public static void ApplicaInteressiATutti()
    {
        foreach (var kv in ctx.Conti)
        {
            var conto = kv.Value;
            var delta = ctx.Strategy.CalcolaDeltaInteressi(conto);
            if (delta != 0)
            {
                conto.Deposita(delta);
                AggiungiOperazione(conto.Id, "interessi", delta, "in base alla strategia");
            }
        }
    }

    public static void StampaOperazioniConto(int contoId)
    {
        if (!ctx.operazioni.ContainsKey(contoId))
        {
            Console.WriteLine($"Nessuna operazione per conto {contoId}");
            return;
        }

        Console.WriteLine($"\n== Operazioni conto {contoId} ==");
        foreach (var op in ctx.operazioni[contoId])
            Console.WriteLine($"{op.Timestamp:yyyy-MM-dd HH:mm:ss} | {op.Tipo,-12} | {op.Importo,8:0.00} | {op.Descrizione}");
    }
    
    public static void ReportBanca()
    {
        Console.WriteLine("\n== Report banca ==");
        decimal totale = 0m;
        foreach (var c in ctx.Conti.Values)
        {
            totale += c.Saldo;
            Console.WriteLine($"Conto {c.Id} ({c.Tipo}) Cliente {c.ClienteId} -> Saldo: {c.Saldo:0.00}");
        }
        Console.WriteLine($"Totale saldi: {totale:0.00}");
    }
}
#endregion


#region MAIN
class Program
{
    static void Main(string[] args)
    {
        var Ctx = BankContext.Instance;
        Ctx.Subscribe(new Logger());

        var alice = BankService.CreaCliente("Alice", "alice@example.com");
        var bob   = BankService.CreaCliente("Bob",   "bob@example.com");
        var carol = BankService.CreaCliente("Carol", "carol@example.com");

        // 2) Conti (Factory)
        var c1 = BankService.CreaConto(alice.Id, "BASE");
        var c2 = BankService.CreaConto(bob.Id,   "PREMIUM");
        var c3 = BankService.CreaConto(carol.Id, "STUDENT");

        // 3) Movimenti base
        BankService.Deposita(c1.Id, 500m);
        BankService.Deposita(c2.Id, 1200m);
        BankService.Deposita(c3.Id, 300m);

        BankService.Preleva(c1.Id, 100m);
        

        // 4) Strategy: cambio e interessi
        Ctx.SetStrategy(new PromoStrategy());
        BankService.ApplicaInteressiATutti();
        

        Console.WriteLine("\nFine demo. Premi Invio per uscire.");
        Console.ReadLine();
    }
}

#endregion