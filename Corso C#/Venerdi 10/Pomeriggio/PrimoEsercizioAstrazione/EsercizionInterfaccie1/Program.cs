using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class Program
{
    public static void Main(string[] args)
    {
        List<IPagamento> pagamentos = new List<IPagamento>();
        bool continua = true;
        while (continua)
        {
            int i = 0;
            Console.WriteLine("\n--- MENU PAGAMENTI ---");
            Console.WriteLine("1 Per ");
            Console.WriteLine("2) Per pagare in contanti");
            Console.WriteLine("3) Per pagare con PayPal");
            Console.WriteLine("4) Esci");

            Console.Write("Scelta: ");
            Utils.ReadLine(out int scelta);
            if (scelta == 0)
            {
                continua = false;
            }
            switch (scelta)
            {
                case 1:
                    
                    break;
            }
        }
        static void AccediSoloUno(List<IPagamento> lista, int indice)
        {
            if (indice >= 0 && indice < lista.Count)
            {
                Console.WriteLine($"Inserisci importo");
                Utils.ReadLine(out float importo);
                
                lista[indice].EseguiPagamento(importo); // Metodo polimorfico
            }
            else
            {
                Console.WriteLine("Indice non valido.");
            }
        }
    }
}