using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        Libro HarryPotter = new Libro("Harry Potter", "J.K Rowling", 1999);
        Libro HarryPotterCaliceFuoco = new Libro("Harry Potter", "J.K Rowling", 1999);

        Console.WriteLine(HarryPotterCaliceFuoco);
        Console.WriteLine(HarryPotter);
        

        Console.WriteLine(HarryPotter.Equals(HarryPotterCaliceFuoco));

        Console.WriteLine(HarryPotterCaliceFuoco.GetHashCode());
        Console.WriteLine(HarryPotter.GetHashCode());
        

	}
}