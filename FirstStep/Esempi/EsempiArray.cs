using System.Net.WebSockets;
using System.Linq;

namespace FirstStep.Esempi
{
    public static class EsempiArray
    {
        static int[] array = new int[10];

        public static void ModificaArray()
        {
            array[0] = 10;
            array[1] = 20;
            int sum = array[0] + array[1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 10;
                Console.WriteLine($"Array[{i}]; {array[i]}");
            }
            array = array.Append(110).ToArray(); // aggiungo un elemento all'array
            Console.WriteLine($"Nuova lunghezza array: {array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 10;
                Console.WriteLine($"Array[{i}]; {array[i]}");
            }
        }

        public static void ModificaMatrice()
        {
            int[,] matrice = new int[3, 3]; // matrice 3x3

            int nRighe = matrice.GetLength(0); // numero di righe
            int nColonne = matrice.GetLength(1); // numero di colonne

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = (i + j + 1) * 10;
                    Console.WriteLine($"Matrice[{i},{j}] = {matrice[i, j]}");
                }
            }
        }

        public static void ModificaLista()
        {
            List<string> nomi = new List<string>();
            nomi.Add("Mario");
            nomi.Add("Luigi");

            nomi.Remove("Mario");
            nomi.Clear(); // rimuove tutti gli elementi della lista
            nomi.Contains("Luigi"); // verifica se la lista contiene l'elemento
        }

        public static int[] creaArray(int lunghezza)
        {
            int[] nuovoArray = new int[lunghezza];
            Console.WriteLine($"insert the elements of the array");

            for (int i = 0; i < nuovoArray.Length; i++)
            {
                Console.WriteLine($"Element in position {i}:");
                nuovoArray[i] = int.Parse(Console.ReadLine());
            }
            return nuovoArray;
        }

        public static int[] createCasualArray()
        {
            Random random = new Random();
            int[] casualArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                casualArray[i] = random.Next(1, 101); // numeri casuali tra 1 e 100
                Console.WriteLine($"Element in position {i}: {casualArray[i]}");
            }
            return casualArray;
        }

        public static void maxValueArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"The maximum value in the array is: {max}");
        }

        public static void minValueArray(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"The minimum value in the array is: {min}");
        }

        public static int[] reverseArray(int[] array)
        {
            int[] reversedArray = array.Reverse().ToArray();
            return reversedArray;
        }

        public static bool searchItemInArray(int[] array, int value)
        {

            foreach (int item in array)
            {
                if (item == value)
                {
                    Console.WriteLine($"value found at the {item} position");
                    return true;
                }
            }
            Console.WriteLine($"value not found");

            return false;
        }

    }
}