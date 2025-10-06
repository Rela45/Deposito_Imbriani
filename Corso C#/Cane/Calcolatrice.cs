using System;


public class Operazioni
{
    public static double Somma(double a, double b)
    {
        return a + b;
    }
    public static double Moltiplicazione(double a, double b)
    {
        return a * b;
    }

    public static void StampaRisultato(String operazione, double risultato)
    {
        Console.WriteLine($"il risultato della {operazione} è {risultato}");
        
    }
}