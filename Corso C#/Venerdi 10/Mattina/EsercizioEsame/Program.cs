
using System;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Universita
{
    public string Nome;
    public List<Studente> Studenti { get; set; }

    public Universita(string nome)
    {
        Nome = nome;
        Studenti = new List<Studente>();
    }

    public void AggiungiStudente(Studente studente)
    {
        Studenti.Add(studente);
    }

    public void StampaStudenti()
    {
        Console.WriteLine($"Università: {Nome}");
        foreach (var studente in Studenti)
        {
            Console.WriteLine(studente);
        }
    }
}

// Classe Studente
class Studente : Universita
{
    public string NomeStudente { get; set; }
    public string Cognome { get; set; }
    public string Matricola { get; set; }

    public Studente(string nomeStudente, string cognome, string matricola, string nome) : base(nome)
    {
        NomeStudente = nomeStudente;
        Cognome = cognome;
        Matricola = matricola;
    }

    public override string ToString()
    {
        return $"Studente: {Nome} {Cognome}, Matricola: {Matricola}";
    }
}

