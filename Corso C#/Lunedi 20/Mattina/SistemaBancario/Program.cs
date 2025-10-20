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

    public Dictionary<int, List<int, >>
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
    decimal Saldo { get; }
    void Deposita(decimal importo);
    bool Preleva(decimal importo);
}
#endregion
#region ConcreteClass
public class Conto : IConto
{
    public int Id => throw new NotImplementedException();

    public int ClienteId => throw new NotImplementedException();

    public string Tipo => throw new NotImplementedException();

    public decimal Saldo => throw new NotImplementedException();

    public void Deposita(decimal importo)
    {
        throw new NotImplementedException();
    }

    public bool Preleva(decimal importo)
    {
        throw new NotImplementedException();
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