using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cane
{

    //Dichiaro gli attributi della classe
    public string nome;
    public int eta;

    //costruttore non presente perchè non inizializzato ma esiste comunque poichè esso è vuoto.
    public void Abbaia()
    {
        Console.WriteLine($"{nome} dice Bau");
    }
}

public class Programma
{
    public static void Main()
    {
        // Cane mioCane = new Cane();

        // mioCane.nome = "Fido";
        // mioCane.eta = 5;
        // mioCane.Abbaia();
        /// <summary>
        /// Esercizio 2 completato con extra
        /// </summary>
        /// <returns></returns>
        Persona p1 = new Persona("Anna", "Borghi", 1999);
        Persona p2 = new Persona("Mario", "Rossi", 1990);

        Persona[] arrayPersone = new Persona[2];

        arrayPersone[0] = p1;
        arrayPersone[1] = p2;


        for (int i = 0; i < arrayPersone.Length; i++)
        {
            arrayPersone[i].Presentati();
        }


        /// <summary>
        /// Esercizio 1
        /// </summary>
        /// <returns></returns>
        Studente s1 = new Studente("Alessandro", 1, 60);
        Studente s2 = new Studente("Cristiano Ronaldo", 7, 110);


        String nome = s1.GetNome();
        int matricola = s1.GetMatricola();
        double avgVoti = s1.GetAvgVoti();


        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Matricola: {matricola}");
        Console.WriteLine($"Media Voti: {avgVoti}");


        String nome2 = s2.GetNome();
        int matricola2 = s2.GetMatricola();
        double avgVoti2 = s2.GetAvgVoti();


        Console.WriteLine($"Nome: {nome2}");
        Console.WriteLine($"Matricola: {matricola2}");
        Console.WriteLine($"Media Voti: {avgVoti2}");

        ///<summary>
        /// Esercizio 3
        ///</summary>

        Operazioni o1 = new Operazioni();

        Console.WriteLine($"Inserisci 2 numeri");

       double num1 = Convert.ToDouble(Console.ReadLine());
       double num2 = Convert.ToDouble(Console.ReadLine());
       double risultato = 0;
       Console.WriteLine($"inserisci l'operazione che vuoi eseguire (+, *)");
       string? operazione = Console.ReadLine();

        if (operazione == "+")
        {
            risultato = Operazioni.Somma(num1, num2);
        }
       
        else if (operazione == "*")
        {
            risultato = Operazioni.Moltiplicazione(num1, num2);
        }



        Operazioni.StampaRisultato(operazione, risultato );
        
        
        
        
        
        

    }
}