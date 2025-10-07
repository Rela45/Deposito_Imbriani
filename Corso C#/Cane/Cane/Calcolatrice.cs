using System;


public class Operazioni
{
    public double Somma(double a, double b)
    {
        return a + b;
    }
    public double Moltiplicazione(double a, double b)
    {
        return a * b;
    }

    public void StampaRisultato(String? operazione, double risultato)
    {
        Console.WriteLine($"il risultato della {operazione} è {risultato}");
        
    }
}