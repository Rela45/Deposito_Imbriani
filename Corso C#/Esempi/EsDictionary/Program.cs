class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> studenti = new Dictionary<int, string>();

        Dictionary<int, List<string>> students = new Dictionary<int, List<string>>();
        //possiamo usare anche un dictionary di dictionary potenzialmente, accetta quindi anche altre liste
        //per la lista possiamo crearla prima e poi la passiamo nel dictionary tramite l'add.
        var capitali = new Dictionary<string, string>
        {
            { "Italia", "Roma" },
            {"Francia", "Parigi"}
        };

        

    }
}