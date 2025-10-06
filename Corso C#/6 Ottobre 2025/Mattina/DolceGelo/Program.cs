namespace DolceGelo
{
    public static void Main(string[] args)
    {
        string[] gusti = { "Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone" };
        double[] prezzi = { 1.50, 1.20, 1.30, 1.80, 1.10 };

        int scelta = 0;

        while (scelta != 4)
        {
            StampaMenu(gusti, prezzi);
            Console.Write("Scegli un'opzione: ");
            scelta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
        }
    }
    
    public static void StampaMenu(string[] gusti, double[] prezzi)
        {
            Console.WriteLine("Gusti disponibili:");
            for (int i = 0; i < gusti.Length; i++)
            {
                Console.WriteLine($"{i} - {gusti[i]} ({prezzi[i].ToString("C2", itIT)})");
            }
            Console.WriteLine();
        }
}