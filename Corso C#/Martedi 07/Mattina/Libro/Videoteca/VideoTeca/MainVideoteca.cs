using System;

class MainVideoteca
{
    public static void Main()
    {
        List<Film> films = new List<Film>();
        int minimoLibri = 3;
        bool continua = true;
        while (continua)
        {
            Console.WriteLine($"add at least 3 films in the library");
            Console.WriteLine($"what's the name of film");
            string? input = Console.ReadLine();
            Console.WriteLine($"Who's the Author?");
            string? author = Console.ReadLine();
            Console.WriteLine($"Insert the year of release");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What's the Genre?");
            string? genre = Console.ReadLine();
            films.Add(new Film(input, author, year, genre));
            if (films.Count < minimoLibri)
            {
                Console.WriteLine($"add another film");
            }
            else
            {
                Console.WriteLine($"Do you want to add more films? y for yes n for no");
                var keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.Y
                )
                {
                    continue;
                }
                else
                {
                    continua = false;
                }
            }  
        }
        for (int i = 0; i < films.Count; i++)
            {
                Console.WriteLine(films[i]);
            }
    }
}

public class Film
{
    string? Titolo;
    string? Regista;
    int Anno;
    string? Genere;

    public Film(string? titolo, string? regista, int anno, string? genere)
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }

    public override string ToString()
    {
        return $"Title: {Titolo}, Director: {Regista}, Year: {Anno}, Genre: {Genere}";
    }

    public void cercaGenere(Object obj)
    {
        //devo completarlo.
    }


}