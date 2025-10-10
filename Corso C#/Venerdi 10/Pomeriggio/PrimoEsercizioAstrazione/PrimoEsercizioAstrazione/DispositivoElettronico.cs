using Venerdi10.PrimoEsercizioAstrazione;

public abstract class DispositivoElettronico
{
    public string? modello { get; private set; }
    protected DispositivoElettronico(string modello)
    {
        this.modello = modello;
    }

    public abstract void Accendi();
    public abstract void Spegni();

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Dispositivo: {GetType().Name} | Modello: {modello}");
        
    }
}