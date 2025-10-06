using Microsoft.VisualBasic;

namespace FirstStep.AnalizzaParola
{
    public static class AnalizzaParola
    {
        public static void Analizza(string parola, out int numeroSpazi, out int numeroVocali, out int numeroConsonanti)
        {
            numeroSpazi = 0;
            numeroVocali = 0;
            numeroConsonanti = 0;
            string comparator = "aeiou";
            foreach (char c in parola)
            {
                if (comparator.Contains(char.ToLower(c)))
                {
                    numeroVocali++;
                }
                if (char.IsWhiteSpace(c))
                {
                    numeroSpazi++;
                }
                else if (char.IsLetter(c) && !comparator.Contains(char.ToLower(c)))
                {
                    numeroConsonanti++;
                }
            }

            Console.WriteLine($"The sentence contains " + numeroVocali + " vowels");
            Console.WriteLine($"The sentence contains " + numeroConsonanti + " consonants");
            Console.WriteLine($"The sentence contains " + numeroSpazi + " spaces");
        }

        public static void Analizza(string parola)
        {
            string result = "";
            foreach (char c in parola)
            {
                if (c != ' ')
                {
                    result += c;
                }
            }
            Console.WriteLine($"The sentence without blanks is: {result}");
        }

        public static void Analizza(string parola, out bool numeroVocali)
        {
            numeroVocali = false;
            int contaVocali = 0;
            int contaConsonanti = 0;
            string comparator = "aeiou";
            foreach (char c in parola)
            {
                if (comparator.Contains(char.ToLower(c)))
                {
                    numeroVocali = true;
                    contaVocali++;
                }
                else if (char.IsLetter(c) && !comparator.Contains(char.ToLower(c)))
                {
                    contaConsonanti++;
                }
            }
            Console.WriteLine($"The sentence contains " + contaVocali + " vowels");
            Console.WriteLine($"The sentence contains " + contaConsonanti + " consonants");
        }

        public static void Analizza(string parola, char carattere)
        {
            int contaCarattere = 0;
            foreach (char c in parola)
            {
                if (char.ToLower(c) == char.ToLower(carattere))
                {
                    contaCarattere++;
                }
            }
            Console.WriteLine($"\nThe character {carattere} is present " + contaCarattere + " times in the sentence");
        }

    }
}
