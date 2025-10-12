using GestionaleCorsi;


class CorsoOnline : Corso
{
    public string? Piattaforma{ set; get;}
    public string? LinkAccesso{ get; set;}
    public CorsoOnline(string titolo, int durata, string? piattaforma, string? linkAccesso) : base(titolo, durata)
    {
        this.Piattaforma = piattaforma;
        this.LinkAccesso = linkAccesso;
    }
    public override void ErogaCorso()
    {
        Console.WriteLine($"Corso erogato completamente");
    }

    public override void stampaDettagli()
    {
        Console.WriteLine($"Titolo corso: {Titolo}, \nDurata: {DurataOre}, \nPiattaforma: {Piattaforma}, \nLinkAccesso: {LinkAccesso}");
    }
}