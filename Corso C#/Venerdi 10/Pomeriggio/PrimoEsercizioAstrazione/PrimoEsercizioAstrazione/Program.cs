using System;
using System.Security.Cryptography;
using Venerdi10.PrimoEsercizioAstrazione;

class Program
{
    static void Main(string[] args)
    {

        List<DispositivoElettronico> lista = new List<DispositivoElettronico>();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1) Aggiungi un Computer");
            Console.WriteLine("2) Aggiungi una stampante");
            Console.WriteLine("3) Accendi dispositivo");
            Console.WriteLine("4) Spegni dispositivo");
            Console.WriteLine("3) Esci");

            Console.Write("Scelta: ");
            Utils.ReadLine(out int scelta);
            if (scelta == 0)
            {
                continua = false;
            }
            switch (scelta)
            {
                case 1:
                    lista.Add(new Computer("dell x1020"));
                    break;
                case 2:
                    lista.Add(new Stampante("Brother mgx 1000"));
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
            }
        }
        static void Spegni(DispositivoElettronico d)
        {
            d.Spegni();
        }
    }
}