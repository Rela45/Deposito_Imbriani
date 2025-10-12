using System.ComponentModel;
using System.Text.RegularExpressions;
using GestionaleCorsi;

class Program
{
    public static void Main(String[] args)
    {
        List<Corso> corsoList = new List<Corso>();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n--- MENU  ---");
            Console.WriteLine($"Aggiungi Corsi");
            Console.WriteLine("1) Corso Online");
            Console.WriteLine("2) Corso in Presenza");
            Console.WriteLine("3) Visualizza tutti i corsi");
            Console.WriteLine($"4) Scegli il corso da erogare");
            
            Utils.ReadLine(out int eroga);
            switch (eroga)
            {
                case 1:
                    Console.WriteLine($"Come si chiama il corso?");
                    Utils.ReadLine(out string nome);
                    Console.WriteLine($"Quante ore di corso sono previste?");
                    Utils.ReadLine(out int numeroOre);
                    Console.WriteLine($"Aggiungi la piattaforma sulla quale vuoi far seguire il corso");
                    Utils.ReadLine(out string piattaforma);
                    Console.WriteLine($"Link di accesso:");
                    Utils.ReadLine(out string linkAccesso);
                    corsoList.Add(new CorsoOnline(nome, numeroOre, piattaforma, linkAccesso));
                    
                    break;
                case 2:
                    Console.WriteLine($"Come si chiama il corso?");
                    Utils.ReadLine(out string nome1);
                    Console.WriteLine($"Quante ore di corso sono previste?");
                    Utils.ReadLine(out int numeroOre2);
                    Console.WriteLine($"Quanti sono i posti in aula?");
                    Utils.ReadLine(out int postiAula );
                    Console.WriteLine($"In quale aula si seguira il corso?");
                    Utils.ReadLine(out string aula);
                    corsoList.Add(new CorsoInPresenza(nome1, numeroOre2, postiAula, aula));
                    break;
                case 3:
                    foreach (Corso s in corsoList)
                    {
                        Console.WriteLine(s);
                    }
                    break;

                case 4:
                    Console.WriteLine($"Inserisci il codice del corso");
                    Utils.ReadLine(out int indice);
                    if(indice >= 0&& indice < corsoList.Count)
                    {
                        corsoList[indice].ErogaCorso();
                        corsoList[indice].stampaDettagli();
                    }
                    break;
                default:
                    continua = false;
                    break;
            }
        }



    }
}