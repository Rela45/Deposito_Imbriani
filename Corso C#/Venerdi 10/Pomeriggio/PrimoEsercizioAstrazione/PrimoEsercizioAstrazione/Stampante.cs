using Venerdi10.PrimoEsercizioAstrazione;

class Stampante : DispositivoElettronico
{
    public Stampante(string modello) : base(modello)
    {
        
    }

    public override void Accendi()
    {
        Console.WriteLine($"Il computer si accende");
        
    }

    public override void Spegni()
    {
        Console.WriteLine($"Il computer si spegne");
    }
}
