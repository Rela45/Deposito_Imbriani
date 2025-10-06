using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace DolceGelo
{
    class Program
    {

        public static void Main(string[] args)
        {
            string[] gusti = ["Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone"];
            double[] prezzi = [1.50, 1.20, 1.30, 1.80, 1.10];

            int scelta = 0;
            int quantita = 0;
            bool continua = true;

            List<int> indiceGusti = new List<int>();

            while (continua == true)
            {
                StampaMenu(gusti, prezzi);
                Console.WriteLine("Scegli un'opzione: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vuoi Aggiungere un altro gusto? Y per si N per No");
                var keyinfo = Console.ReadKey();
                indiceGusti.Add(scelta);
                if (keyinfo.Key == ConsoleKey.Y)
                {
                    quantita++;
                    continue;
                }
                else
                {
                    continua = false;
                }

            }

            

        }

        public static void StampaMenu(string[] gusti, double[] prezzi)
        {
            Console.WriteLine("Gusti disponibili:");
            for (int i = 0; i < gusti.Length; i++)
            {
                Console.WriteLine($"{i} - {gusti[i]} ({prezzi[i].ToString("C2")})");
            }
            Console.WriteLine();
        }

        public static double CalcolaTotale(int indiceGusti, int quantitaGusti)
        {
            return 0;
        } 
    }
}