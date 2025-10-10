using Venerdi10.PrimoEsercizioAstrazione;

class Computer : DispositivoElettronico
{
    public Computer(string modello) : base(modello)
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