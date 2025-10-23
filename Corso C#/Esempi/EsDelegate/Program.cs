using System.Security.Authentication;

public delegate void Saluto(string nome);
public delegate int OperationDelegate(int a, int b);    //delegate con ritorno di somma
class Pulsante
{
    public event Action Premuto;
    public void SimulaClick()
    {
        Console.WriteLine($"Pulsante Cliccato");
        Premuto?.Invoke();
    }
}
class Program
{


    static void Ciao(string nome)
    {
        Console.WriteLine($"Ciao! {nome}");
    }
    static int Add(int x, int y)              //metodo delegate con return
    {
        return x + y;
    }



    static void Main(string[] args)  
    {
        OperationDelegate op1 = Add;
        Saluto s = Ciao;
        s("Marco");

        s += nome => Console.WriteLine($"Benvenuto {nome}");  //Delegate Multicast

        Action<string> saluta = nome => Console.WriteLine($"Ciao, {nome}");
        saluta("Michele");
        Func<int, int, int> somma = (a, b) => a + b;
        Console.WriteLine(somma(3, 4));

        //uso pulsante
        Pulsante p = new Pulsante();
        p.Premuto += () => Console.WriteLine($"Evento Ricevuto");
        p.SimulaClick();
        
    }

}