class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Inserisci il tipo di veicolo che vuoi creare");
        string? input = Console.ReadLine();
        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(input);
        veicolo.Start();
        veicolo.ShowType();
    }
}