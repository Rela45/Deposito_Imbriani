using System;

public class Libro
{
    string? Titolo;
    string? Autore;

    int AnnoPubblicazione;

    public Libro(string titolo, string autore, int annoPubblicazione)
    {
        this.Titolo = titolo;
        this.Autore = autore;
        AnnoPubblicazione = annoPubblicazione;
    }

    public override string ToString()
    {
        return $"Titolo: {Titolo}, Autore: {Autore}, Anno: {AnnoPubblicazione}";
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is not Libro other) return false;
        return Titolo == other.Titolo && Autore == other.Autore;
    }

    
    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);
    }
}

    
