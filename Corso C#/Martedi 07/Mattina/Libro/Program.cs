using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main()
    {
        Libro HarryPotter = new Libro("Harry Potter", "J.K Rowling", 1999);
        Libro HarryPotterCaliceFuoco = new Libro("Harry Potter", "J.K Rowling", 1999);

        Libro[] Libri = new Libro[2];

        Libri[0] = HarryPotter;
        Libri[1] = HarryPotterCaliceFuoco;
        

        Console.WriteLine(HarryPotterCaliceFuoco);
        Console.WriteLine(HarryPotter);
        

        Console.WriteLine(HarryPotter.Equals(HarryPotterCaliceFuoco));

        Console.WriteLine(HarryPotterCaliceFuoco.GetHashCode());
        Console.WriteLine(HarryPotter.GetHashCode());

        for (int i = 0; i < Libri.Length; i++) {
            Console.WriteLine(Libri[i]);
        }
	}
}