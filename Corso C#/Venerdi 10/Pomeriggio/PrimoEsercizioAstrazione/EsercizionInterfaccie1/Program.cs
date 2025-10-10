using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class Program
{
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
    public static void Main(string[] args)
    {
        List<IPagamento> pagamentos = new List<IPagamento>();
        bool continua = true;
        int i = 0;
        while (continua)
        {
            Console.WriteLine("\n--- MENU PAGAMENTI ---");
            Console.WriteLine("1 Per pagare con carta ");
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
                    pagamentos.Add(new PagamentoCarta());
                    Console.WriteLine($"Inserisci importo");
                    Utils.ReadLine(out float importo);
                    pagamentos[i].EseguiPagamento(importo);
                    break;
                case 2:
                    pagamentos.Add(new PagamentoContanti());
                    Utils.ReadLine(out float importo2);
                    pagamentos[i].EseguiPagamento(importo2);
                    break;
                case 3:
                    pagamentos.Add(new PagamentoPayPal());
                    Utils.ReadLine(out float importo3);
                    pagamentos[i].EseguiPagamento(importo3);
                    break;
            }
            i++;
            foreach(PagamentoCarta p in pagamentos)
            {
                Console.WriteLine(p);
                
            }
            // AccediSoloUno(pagamentos, i);
        }
    }
}

