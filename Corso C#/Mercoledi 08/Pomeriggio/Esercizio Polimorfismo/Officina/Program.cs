using System;

class Veicolo         //padre
{
    private string? _targa;


    public string? Targa { get => _targa; set => _targa = value; }

    public Veicolo(string? targa)
    {
        _targa = targa;
    }

    public virtual void Ripara()
    {
        Console.WriteLine($"Il veicolo viene controllato");
    }

    public virtual void Ripara(string targa)
    {
        Console.WriteLine("$Controllo olio dell'auto con targa: " + Targa);
    }


}

class Auto : Veicolo
{
    public Auto(string? targa) : base(targa)
    {

    }

    public void Ripara(string targa)
    {
        Console.WriteLine("$Controllo olio dell'auto con targa: " + Targa);
    }

}

class Moto : Veicolo
{
    public Moto(string? targa) : base(targa)
    {

    }
    public override void Ripara(string? targa)
    {
        Console.WriteLine("$Controllo catena, freni e gomme con targa: " + Targa);
    }

}

class Camion : Veicolo
{
    public Camion(string? targa) : base(targa)
    {

    }


    public override void Ripara(string? targa)
    {
        Console.WriteLine("$Controllo sospensioni, freni rinforzati e carico del camion con targa: " + Targa);
    }

}






class Program
{
    static void Main(string[] args)
    {

        List<Veicolo> veicoli = new List<Veicolo>();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("Inserire il tipo di veicolo (Auto, Moto, Camion) o 'esci' per terminare:");
            string? input = Console.ReadLine();
            if (input == "esci")
            {
                continua = false;
                continue;
            }
            Console.WriteLine("Inserire la targa:");
            string? targa = Console.ReadLine();
            switch (input)
            {
                case "Auto":
                    veicoli.Add(new Auto(targa));


                    break;
                case "Moto":
                    veicoli.Add(new Moto(targa));

                    break;
                case "Camion":
                    veicoli.Add(new Camion(targa));

                    break;
                default:
                    Console.WriteLine("Tipo di veicolo non riconosciuto.");
                    break;
            }


            foreach (Veicolo veicolo in veicoli)
            {
                veicolo.Ripara();
                veicolo.Ripara(veicolo.Targa); 
            }

        }
    }
}