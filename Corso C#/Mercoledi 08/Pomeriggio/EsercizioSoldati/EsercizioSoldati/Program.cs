using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Soldato
{
    private string? nome;
    private string? grado;
    private int anniServizio;

    public string? Nome { get; set; }
    public string? Grado { get; set; }

    public int AnniServizio
    {
        get => anniServizio;
        set => anniServizio = (value >= 0) ? value : 0; // solo valori >= 0
    }

    public Soldato(string nome, string grado, int anniServizio)
    {
        this.nome = nome;
        this.grado = grado;
        AnniServizio = anniServizio;
    }

    public virtual string? Descrizione()
    {
        return $"Nome: {nome} , Grado: {grado}, Anni di servizio: {anniServizio}";

    }
}


class Fante : Soldato
{
    private string? arma;

    public string? Arma { get; set; }

    public Fante(string nome, string grado, int anniServizio, string arma)
                : base(nome, grado, anniServizio)
    {
        Arma = arma;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + $" | Arma: {Arma}";
    }
}

class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get => calibro;
        set => calibro = (value >= 0) ? value : 0;
    }

    public Artigliere(string nome, string grado, int anniServizio, int calibro)
                : base(nome, grado, anniServizio)
    {
        this.calibro = calibro;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Soldato> esercito = new List<Soldato>();
        bool esci = false;

        while (!esci)
        {
            Console.WriteLine("\n--- MENU ESERCITO ---");
            Console.WriteLine("1) Aggiungi Fante");
            Console.WriteLine("2) Aggiungi Artigliere");
            Console.WriteLine("3) Visualizza tutti");
            Console.WriteLine("4) Esci");
            Console.Write("Scelta: ");

            int scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Nome: ");
                    string? nome = Console.ReadLine();
                    Console.WriteLine($"Grado:");
                    string? grado = Console.ReadLine();
                    Console.WriteLine($"anni di servizio:");
                    int anniServizio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Arma:");
                    string? arma = Console.ReadLine();
                    esercito.Add(new Fante(nome, grado, anniServizio, arma));
                    Console.WriteLine("Fante aggiunto con successo");
                    break;
                case 2:
                    Console.WriteLine($"Nome: ");
                    string? nome2 = Console.ReadLine();
                    Console.WriteLine($"Grado:");
                    string? grado2 = Console.ReadLine();
                    Console.WriteLine($"anni di servizio:");
                    int anniServizio2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Calibro:");
                    int calibro = Convert.ToInt32(Console.ReadLine());
                    esercito.Add(new Artigliere(nome2, grado2, anniServizio2, calibro));
                    
                    break;
                case 3:
                    foreach (var s in esercito)
                        Console.WriteLine(s.Descrizione());
                    break;
                case 4:
                    esci = true;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

    }
}

