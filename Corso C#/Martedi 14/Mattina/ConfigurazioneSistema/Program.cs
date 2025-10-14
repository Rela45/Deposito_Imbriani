
namespace ConfigurazioneSistema
{
    class Program
    {
        public static void Main(string[] args)
        {
            //creo le istanze 
            var ModuloA = ConfigurazioneSistema.GetInstance();
            var ModuloB = ConfigurazioneSistema.GetInstance();

            //imposto i valori in dictionary
            ModuloA.Imposta("key1", "value1");
            ModuloB.Imposta("key2", "value2");

            //leggo i valori in dictionary passandogli la key
            ModuloA.Leggi("key1");
            ModuloB.Leggi("key2");


            //controllo se entrambe le classi siano sulla stessa instance
            bool stessaIstanza = Object.ReferenceEquals(ModuloA, ModuloB);
            Console.WriteLine();
            Console.WriteLine($"Stessa istanza? {stessaIstanza}");
            Console.WriteLine($"HashCode ModuloA: {ModuloA.GetHashCode()} | HashCode ModuloB {ModuloB.GetHashCode()}");

            Console.WriteLine("\nPremi un tasto per uscire...");
            Console.ReadKey();

            //stampo tutte le chiavi e i valori
            ModuloA.StampaTutte();
            ModuloB.StampaTutte();

        }
    }
}
