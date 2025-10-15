﻿class Program
{
    public static void Main(string[] args)
    {
        var soggetto = new CentroMeteo();

        var console = new DisplayConsole("console");
        var mobile = new DisplayMobile("mobile");

        soggetto.Registra(console);
        soggetto.Registra(mobile);

        Console.WriteLine($"Inserisci il meteo di adesso");
        string? meteo = Console.ReadLine();

        soggetto.AggionaMeteo(meteo);
        
    }
}