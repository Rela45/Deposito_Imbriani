using GestionaleCorsi;

class CorsoInPresenza : Corso
{
    private int _numeroPosti;

public int NumeroPosti
{
    get { return _numeroPosti; }
    set
    {
        if (value != 0) // check incoming value, not old one
            _numeroPosti = value;
    }
}
    public string? Aula { get; set; }
    public CorsoInPresenza(string titolo, int durata, int nPosti,string aula) : base(titolo, durata)
    {
        NumeroPosti = nPosti;
        Aula = aula;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Corso erogato completamente");
        
    }

    public override void stampaDettagli()
    {
        Console.WriteLine($"Titolo corso: {Titolo}, \nDurata: {DurataOre}, \nNumeroPosti: {NumeroPosti} , \nAula: {Aula}");
        
    }
}