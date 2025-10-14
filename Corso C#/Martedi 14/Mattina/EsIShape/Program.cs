using System.Net.WebSockets;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Vuoi costruire un cerchio o un quadrato?");
        string tipo = Console.ReadLine();
        switch (tipo)
        {
            case "cerchio":
                Circle cerchio = new Circle();
                cerchio.Shape(tipo);
                break;
            case "quadrato":
                Circle quadrato = new Circle();
                quadrato.Shape(tipo);
                break;
            default:
                Console.WriteLine("Forma non valida");
                break;
        }

        
    }
}