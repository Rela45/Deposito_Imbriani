

#region MAIN

class Program
{
    // Delegato per l'operazione matematica
    delegate int Operazione(int a, int b);

    // Delegato per il logging
    delegate void Logger(string messaggio);

    static void Main()
    {
        // Creiamo un logger che scrive in console
        Logger logger = MessaggioConsole;

        // Console.WriteLine($"===============MENU================ \n 1.Esegui somma\n 2.Esegui Moltiplicazione");
        
        int risultatoSomma = EseguiOperazione(Somma, 5, 3, logger);
        int risultatoMoltiplicazione = EseguiOperazione(Moltiplica, 5, 3, logger);

        Console.WriteLine($"\nRisultato Somma: {risultatoSomma}");
        Console.WriteLine($"Risultato Moltiplicazione: {risultatoMoltiplicazione}");
    }

    // Metodo che esegue un’operazione e logga l’evento
    static int EseguiOperazione(Operazione op, int x, int y, Logger logger)
    {
        logger($"Eseguo l’operazione su {x} e {y}...");
        int risultato = op(x, y);
        logger($"Operazione completata. Risultato = {risultato}");
        return risultato;
    }

    // Metodo per sommare
    static int Somma(int a, int b)
    {
        return a + b;
    }

    // Metodo per moltiplicare
    static int Moltiplica(int a, int b)
    {
        return a * b;
    }

    // Metodo logger
    static void MessaggioConsole(string messaggio)
    {
        Console.WriteLine($"[LOG] {messaggio}");
    }
}

#endregion