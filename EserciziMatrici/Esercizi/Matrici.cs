using System.Globalization;

public static class Matrici
{
    public static int[,] creaMatrici(int nRighe, int nColonne)
    {
        int[,] nuovaMatrice = new int[nRighe, nColonne];
        Console.WriteLine($"insert the elements of the array");
        for (int i = 0; i < nRighe; i++)
        {
            for (int j = 0; j < nColonne; j++)
            {
                Console.WriteLine($"Element in position {i},{j}:");
                nuovaMatrice[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < nRighe; i++)
        {
            for (int j = 0; j < nColonne; j++)
            {
                Console.Write(nuovaMatrice[i, j] + "\t");
            }
            Console.WriteLine();
        }
        return nuovaMatrice;
    }

    public static int sumValueMatrix(int[,] sumMatrix)
    {
        int somma = 0;

        for (int i = 0; i < sumMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sumMatrix.GetLength(1); j++)
            {
                somma += sumMatrix[i, j];
            }
        }
        Console.WriteLine($"the sum of the elements of the matrix is: {somma}");
        return somma;

    }
    
    
}