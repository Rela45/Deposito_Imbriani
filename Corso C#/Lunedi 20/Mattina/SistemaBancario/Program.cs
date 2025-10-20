#region Singleton
using System.Dynamic;

public sealed class BankContext
{
    private BankContext _instance;
    
    
    private BankContext()
    {

    }
    public BankContext Instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    public Dictionary<int, Cliente> Clienti = new();
    public Dictionary<int, IConto> Conti = new();

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
#region Interface
public interface IConto
{
    int Id { get; }
    int ClienteId { get; }
    string Tipo { get; }
    decimal Saldo { get; set; }
    void Deposita(decimal importo);
    bool Preleva(decimal importo);
}
#endregion
#region ConcreteClass
public abstract class Conto : IConto
{
    public int Id { get; }
    public int ClienteId { get; }
    public string Tipo { get; }
    public decimal Saldo { get; set; }
    protected Conto(int id, int ClienteId, string Tipo, decimal Saldo)
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
    public ContoBase(int id, int ClienteId, string Tipo, decimal Saldo) : base(id, ClienteId, "ContoBase", Saldo)
    {
    }
}

public class ContoPremium : Conto
{
    public ContoPremium(int id, int ClienteId, string Tipo, decimal Saldo) : base(id, ClienteId, "Conto Premium", Saldo)
    {
    }
}

public class ContoStudent : Conto
{
    public ContoStudent(int id, int ClienteId, string Tipo, decimal Saldo) : base(id, ClienteId, "Conto Student", Saldo)
    {
    }
}
#endregion
#region Factory



#endregion




#region Strategy 


#endregion



#region Observer 


#endregion



#region MAIN
class Program
{
    static void Main(string[] args)
    {

    }
}

#endregion