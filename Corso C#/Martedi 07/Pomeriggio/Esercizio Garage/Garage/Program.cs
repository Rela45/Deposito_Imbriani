using System;

public class Veicolo
{
    protected string? Marca;
    protected string? Modello;

    public Veicolo(string? marca, string? modello)
    {
        Marca = marca;
        Modello = modello;
    }

    public override string? ToString()
    {
        return $"Marca: {Marca}, Modello: {Modello}";

    }
}


public class Auto : Veicolo
{
    protected int NumeroPorte;
    public Auto(string? marca, string? modello, int NumeroPorte) : base(marca, modello) //sovrascrivo il costruttore
    {
        this.Marca = marca;
        this.Modello = modello;
        this.NumeroPorte = NumeroPorte;
    }
    public override string? ToString()
    {
        return $"Auto - {base.ToString()}";
    }
    
}   

public class Moto : Veicolo
{
    protected string? tipoManubrio;
    public Moto(string? marca, string? modello, string? tipoManubrio) : base(marca, modello)
    {
        this.Marca = marca;
        this.Modello = modello;
        this.tipoManubrio = tipoManubrio;
        
    }
    public override string ToString()
    {
        return $"Moto - {base.ToString()}";
    }
    
}
class Program
{
    public static void Main()
    {
        // Veicolo veicolo1 = new Auto("Fiat", "Punto");
        // Veicolo veicolo2 = new Moto("Yamaha", "R1");

        // Console.WriteLine(veicolo1.ToString());
        // Console.WriteLine(veicolo2.ToString());

        List<Veicolo> garage = new List<Veicolo>();
        bool continua = true;
        while(continua){
            Console.WriteLine($"Inserisci 1 per aggiungere un'auto, \n2 per aggiungere una moto, \n3 per visualizzare il garage, \n4 per uscire");
            
            int scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Inserisci marca auto");
                    string? marcaAuto = Console.ReadLine();
                    Console.WriteLine("Inserisci modello auto");
                    string? modelloAuto = Console.ReadLine();
                    int nPorte = Convert.ToInt32(Console.ReadLine());
                    
                    garage.Add(new Auto(marcaAuto, modelloAuto, nPorte));
                    break;
                case 2:
                    Console.WriteLine("Inserisci marca moto");
                    string? marcaMoto = Console.ReadLine();
                    Console.WriteLine("Inserisci modello moto");
                    string? modelloMoto = Console.ReadLine();
                    Console.WriteLine("Inserisci tipo manubrio");
                    string? tipoManubrio = Console.ReadLine();
                    
                    garage.Add(new Moto(marcaMoto, modelloMoto, tipoManubrio));
                    break;


                case 3:
                    foreach (Veicolo veicolo in garage)
                    {
                        Console.WriteLine(veicolo.ToString());
                    }
                    break;

                case 4:
                    Console.WriteLine("Programma terminato");
                    continua = false;
                    break;
            }   
        }
    }
}