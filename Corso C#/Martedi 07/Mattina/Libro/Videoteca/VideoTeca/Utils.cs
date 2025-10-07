
    public static class Utils
    {
        public static int IntReadLine(string prompt)
        {
            {
                int value;
                while (true)
                {
                    Console.WriteLine(prompt);
                    if (int.TryParse(Console.ReadLine(), out value))
                    {
                        return value;
                    }
                    Console.WriteLine("Input non valido. Per favore, inserisci un numero intero.");
                }
            }
        }
    }

