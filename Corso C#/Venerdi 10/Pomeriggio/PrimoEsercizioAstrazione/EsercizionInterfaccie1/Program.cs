using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class Program
{
    public static void Main(string[] args)
    {
        List<IPagamento> pagamentos = new List<IPagamento>();
        bool continua = true;
        int i = 0;

        while (continua)
        {
            Console.WriteLine("\n--- MENU PAGAMENTI ---");
            Console.WriteLine("1) Pagamento con carta");
            Console.WriteLine("2) Pagamento in contanti");
            Console.WriteLine("3) Pagamento con PayPal");
            Console.WriteLine("4) Esci");

            Console.Write("Scelta: ");
            Utils.ReadLine(out int scelta);

            switch (scelta)
            {
                case 1:
                    pagamentos.Add(new PagamentoCarta());
                    AccediSoloUno(i);
                    i++;
                    break;
                case 2:
                    pagamentos.Add(new PagamentoContanti());
                    AccediSoloUno(i);
                    i++;
                    break;
                case 3:
                    Console.WriteLine($"Aggiungi Email Utente");
                    Utils.ReadLine(out string email);
                    pagamentos.Add(new PagamentoPayPal(email));
                    AccediSoloUno(i);

                    i++;
                    break;
                case 4:
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }

        }

        // Method inside Main
        void AccediSoloUno(int indice)
        {
            if (indice >= 0 && indice < pagamentos.Count)
            {
                Console.WriteLine("Accesso garantito");
                Console.WriteLine("Inserisci importo:");
                Utils.ReadLine(out float importo);
                pagamentos[indice].MostraMetodo();
                pagamentos[indice].EseguiPagamento(importo); // Polymorphic call
            }
            else
            {
                Console.WriteLine("Indice non valido.");
            }
        }
    }
}
