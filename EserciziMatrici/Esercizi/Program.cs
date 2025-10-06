namespace FirstStep.Utilities;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"how many rows");
        int nRows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"how many columns");
        int nColumns = Convert.ToInt32(Console.ReadLine());
        int[,] sumMatrix = Matrici.creaMatrici(nRows, nColumns);
        Matrici.sumValueMatrix(sumMatrix);
        
    }
}