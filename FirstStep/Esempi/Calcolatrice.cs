namespace FirstStep.Esempi
{
    public static class Calcolatrice
    {
        public static int Somma(int a, int b)
        ///
        /// <summary>
        /// Somma due numeri interi e restituisce il risultato.
        /// </summary>
        /// <param name="a">Il primo numero intero.</param>
        {
            return a + b;
        }

        public static float Somma(float a, float b)
        {
            return a + b;
        }

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static int Somma(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        public static void IncrementaRef(ref int numero)
        {
            numero++;
        }

        public static void MoltiplicaPer2(int fattore, out int risultato)
        {
            risultato = fattore * 2; // con out devo inizializzare la variabile
            ;
        }

        public static int Raddoppia(ref int numero)
        {
            numero *= 2;
            return numero;
        }

        public static void Dividi(int dividendo, int divisore, out int quoziente, out int resto)
        {
            quoziente = dividendo / divisore;
            resto = dividendo % divisore;
        }

        public static void VerificaPariDispari(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} è un numero pari.");
            }
            else
            {
                Console.WriteLine($"{numero} è un numero dispari.");
            }
        }

        public static int Potenza(int baseNum, int esponente)
        {
            int risultato;
            risultato = (int)Math.Pow(baseNum, esponente);
            return risultato;
        }

        public static int Somma(int[] arrayDiInteri)
        {
            int somma = 0;
            for (int i = 0; i < arrayDiInteri.Length; i++)
            {
                somma += arrayDiInteri[i];
            }
            return somma;
        }


    }
}
