class CreaMatriceCasuale
{
    public static int[,] CreaMatrice(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(0, 50); //assegna un valore casuale tra 0 e 50

            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        return matrix;
    }
}