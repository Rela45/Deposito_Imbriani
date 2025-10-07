using System;

public class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;
    public Persona(string Nome, string Cognome, int AnnoNascita)
    {
        this.Nome = Nome;
        this.Cognome = Cognome;
        this.AnnoNascita = AnnoNascita;
    }

    public void Presentati()
    {
        Console.WriteLine($"Ciao , sono {Nome} {Cognome} e sono nato nel {AnnoNascita}");
    }
}
