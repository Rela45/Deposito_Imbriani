using GestionaleCorsi;

class CorsoInPresenza : Corso
{
    private string? _aula;
    private int _numeroPosti;
    public int numeroPosti { get { return numeroPosti; } set { if (numeroPosti != 0) numeroPosti = value; } }
    public string? Aula { get; set; }
    public CorsoInPresenza(string titolo, int durata, int nPosti,string aula) : base(titolo, durata)
    {
        numeroPosti = nPosti;
        Aula = aula;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Corso erogato completamente");
        
    }

    public override void stampaDettagli()
    {
        Console.WriteLine($"Titolo corso: {Titolo}, \nDurata: {DurataOre}, \nNumeroPosti: {numeroPosti} , \nAula: {Aula}");
        
    }
}