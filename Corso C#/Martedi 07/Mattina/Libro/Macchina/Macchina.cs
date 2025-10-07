class Macchina
{
    string Motore;

    int SospensioniMax;
    float VelocitaMac;
    int nModifiche;

    public Macchina(string motore, int sospensioniMax, float velocitaMac, int nModifiche)
    {
        Motore = motore;
        SospensioniMax = sospensioniMax;
        VelocitaMac = velocitaMac;
        this.nModifiche = nModifiche;
    }

    public override string ToString()
    {
        return $"Motore: {Motore}, SospensioniMax: {SospensioniMax}, VelocitaMac: {VelocitaMac}, nModifiche: {nModifiche}";
    }


    public float aumentaVelocita()
    {
        return VelocitaMac + 10;
    }

    public int aumentaSospensioni()
    {
        return SospensioniMax++;
    }

    public String modificaMotore()
    {
        Console.WriteLine($"Che motore vuoi inserire?");
        string? input = Console.ReadLine();
        Motore = input;
        return Motore;
    }
}