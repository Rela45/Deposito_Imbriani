// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.ComponentModel.Design.Serialization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using FirstStep.AggiustaData;
using FirstStep.Esempi;
using FirstStep.Saluto; 
using FirstStep.AnalizzaParola;
using System.Threading.Channels;
using System.Security.Cryptography;




class Program
{
    static void Main(string[] args)
    {
        //----------------------------------------input da tastiera example------------------------------------------------------- 
        //   Console.WriteLine($"Inserisci il tuo nome: ");

        //   string nome = Console.ReadLine();
        //   if (string.IsNullOrEmpty(nome))
        //   {
        //       Console.WriteLine("Non hai inserito il nome!");
        //       return;
        //   }

        //   Console.WriteLine($"Ciao {nome}, benvenuto nel corso di C#!");



        // Console.WriteLine($"premi un tasto");

        //   var keyinfo = Console.ReadKey(true);
        //   if(keyinfo.Key == ConsoleKey.S)
        //   {
        //       Console.WriteLine($"hai premuto s, ciao!");
        //       return;
        //   }else
        //   {
        //       Console.WriteLine($"haddi premuto {keyinfo.Key}, ciao!");
        //       return;
        //   }


        // Console.WriteLine($"Dammi un numero");
        // string? n1 = Console.ReadLine();
        // Console.WriteLine($"Dammi un altro numero");
        // string? n2 = Console.ReadLine();

        // float num1 = float.Parse(n1);
        // float num2 = float.Parse(n2);

        // Console.WriteLine($"first number = {num1} \n second number = {num2}");
        // Console.WriteLine($"sum is:  {num1 + num2}");

        //------------------------------------------------OPERATORI ARITMETICI---------------------------------------------------------------

        //         Console.WriteLine("Operatori aritmetici:");
        //         float a = 10;
        //         float b = 3;
        // Console.WriteLine($"a = {a}, b = {b}");
        // Console.WriteLine($"Addizione: a + b = {a + b}");
        // Console.WriteLine($"Sottrazione: a - b = {a - b}");
        // Console.WriteLine($"Moltiplicazione: a * b = {a * b}");
        // Console.WriteLine($"Divisione: a / b = {a / b}");
        // Console.WriteLine($"Modulo (resto): a % b = {a % b}");
        // Console.WriteLine("Operatori Assegnamento:");
        // Console.WriteLine($"Incremento: a++ = {a++}"); // Stampa a, poi incrementa a di 1
        // Console.WriteLine($"Ora a = {a}");
        // Console.WriteLine($"Decremento: --b = {--b}"); // Stampa b, poi decrementa b di 1
        // Console.WriteLine($"Ora b = {b}");
        //--------------------------------------------------------Condizioni if else--------------------------------------------------------------------

        // int a = 5;
        // int b = 10; 
        // if (a > b)
        // {
        //     Console.WriteLine($"a è maggiore di b");
        // }
        // else if (a < b)
        // {
        //     Console.WriteLine($"a è minore di b");
        // }
        // else
        // {
        //     Console.WriteLine($"a è uguale a b");
        // }

        //----------------------------------------------------------CICLI WHILE E FOR--------------------------------------------------------------------
        // bool continua = true;
        // int contatore = 0;
        // while (contatore < 100)
        // {
        //     Console.WriteLine($"Ciao, questo è il ciclo while, contatore = {contatore}");
        //     contatore++;
        // }

        // Console.WriteLine($"inserisci un numero per il ciclo for:");
        // int i = Convert.ToInt32(Console.ReadLine()); // fa la stessa cosa di int.Parse ma gestisce anche il null
        // int contaA = 0, contaZ = 0, contaL = 0;
        // for (int j = 0; j < i; j++)
        // {
        //     Console.WriteLine($"Ciao, questo è il ciclo for, contatore = {j}");
        //     Console.WriteLine($"premi un tasto tra a, z , l per continuare");

        //     var keyinfo = Console.ReadKey();
        //     switch (keyinfo.Key)
        //     {
        //         case ConsoleKey.A:
        //             Console.WriteLine($"hai premuto a, ciao!");
        //             contaA++;
        //             break;
        //         case ConsoleKey.Z:
        //             Console.WriteLine($"hai premuto z, ciao!");
        //             contaZ++;
        //             break;
        //         case ConsoleKey.L:
        //             Console.WriteLine($"hai premuto l, ciao!");
        //             contaL++;
        //             break;
        //         default:
        //             Console.WriteLine($"hai premuto {keyinfo.Key}, ciao!");
        //             break;
        //     }
        // }
        // Console.WriteLine($"Hai premuto a {contaA} volte, z {contaZ} volte, l {contaL} volte");
        // string parola = "CSharp";
        // string parolaCorretta = "";
        // Console.WriteLine("Caratteri della stringa:");
        // foreach (char carattere in parola)
        // {
        //     Console.WriteLine(carattere);
        // }


        // Console.WriteLine($"c'è sharp in parola? {parola.Contains("Sharp")}");
        // //Char
        // char carattere = 'A';
        // Console.WriteLine(char.IsLetter(carattere));
        // Console.WriteLine(char.IsDigit(carattere));
        // Console.WriteLine(char.ToLower(carattere)); //stampa il carattere in minuscolo
        // carattere = char.ToLower(carattere); // rende il carattere minuscolo
        // Console.WriteLine(carattere);

        //-----------------------------------------------USO DELLA CLASSE CALCOLATRICE-------------------------------------------------------
        // int risultato = Calcolatrice.Somma(5, 10);
        // Console.WriteLine($"Il risultato della somma è: {risultato}");

        // int numero = 5;
        // Calcolatrice.IncrementaRef(ref numero);
        // Console.WriteLine($"Numero dopo IncrementaRef: {numero}");
        // int numeroMoltiplicato;
        // Calcolatrice.MoltiplicaPer2(5, out numeroMoltiplicato);
        // Console.WriteLine($"Numero dopo MoltiplicaPer2: {numeroMoltiplicato}");
        //----------------------------------------USO DEL METODO RADDOPPIA CON PARAMETRO REF-------------------------------------------------
        /// <summary>
        /// Esempio di utilizzo del metodo Raddoppia con parametro ref
        /// </summary>
        // int numberToDouble = 4;
        // Console.WriteLine($"Numero prima di Raddoppia: {numberToDouble}");

        // Calcolatrice.Raddoppia(ref numberToDouble);
        // Console.WriteLine($"Numero dopo Raddoppia: {numberToDouble}");
        //--------------------------------------------------USO DELLA CLASSE AGGIUSTA DATA----------------------------------------------------

        // int giorno = 21;
        // int mese = 11;
        // int anno = 2025;
        // Console.WriteLine($"Data prima di PassaData: {giorno}/{mese}/{anno}");
        // AggiustaData.PassaData(ref giorno, ref mese, ref anno);
        // Console.WriteLine($"Data dopo PassaData: {giorno}/{mese}/{anno}");

        //--------------------------------------------------USO DEL METODO DIVIDI CON PARAMETRI OUT----------------------------------------------------

        // int dividendo = 10;
        // int divisore = 3;
        // Calcolatrice.Dividi(dividendo, divisore, out int quoziente, out int resto);
        // Console.WriteLine($"Dividendo: {dividendo}, Divisore: {divisore}");
        // Console.WriteLine($"Quoziente: {quoziente}, Resto: {resto}");


        //--------------------------------------------------Metodo StampaSaluto----------------------------------------------------
        // string nomeUtente = "Mario";
        // Saluto.StampaSaluto(nomeUtente);

        //---------------------------------------------------Metodo VerificaPariDispari----------------------------------------------------
        // int numeroDaVerificare = 7;
        // Calcolatrice.VerificaPariDispari(numeroDaVerificare);


        //---------------------------------------------------Metodo Potenza---------------------------------------------------
        // int baseNum = 2;
        // int esponente = 3;
        // int risultato = Calcolatrice.Potenza(baseNum, esponente);
        // Console.WriteLine($"{risultato}");
        //---------------------------------------------------Metodo ContaLettere---------------------------------------------------
        // string parola = "Forza napoli";
        // AnalizzaParola.ContaLettere(parola, out int numeroSpazi, out int numeroVocali, out int numeroConsonanti);

        //---------------------------------------------------Metodo AggiustaPunteggio---------------------------------------------------

        ///
        /// <summary>
        /// da aggiustare, esercizio copiato dal prof ma non mi trovo   
        /// </summary>

        // int punteggioCorrente = 0; int bonus = 0, totale = 0, turno = 1; double media = 0;
        // punteggioCorrente = Utils.IntReadLine("$Inserisci il punteggio corrente");
        // for (int i = 1; i <= 3; i++)
        // {
        //     bonus = Utils.IntReadLine($"Inserisci il bonus del turno");
        //     AggiustaPunteggio.Aggiusta(ref punteggioCorrente, bonus, ref totale, ref turno, out media);

        // }
        // Console.WriteLine($"La media dei punteggi è {media}");


        //---------------------------------------------------Esempio somma Overload---------------------------------------------------

        // Console.WriteLine($"Somma int: {Calcolatrice.Somma(5, 10)}");
        // Console.WriteLine($"Somma float: {Calcolatrice.Somma(5.5f, 10.3f)}");
        // Console.WriteLine($"Somma double: {Calcolatrice.Somma(5.5, 10.3)}");
        // Console.WriteLine($"Somma con 3 parametri: {Calcolatrice.Somma(5, 10, 15)}");

        //---------------------------------------------------Esempio Analizza Parola Overload---------------------------------------------------

        // Console.WriteLine($"digit a text to analyze:");
        // string? textToAnalyze = Console.ReadLine();
        // AnalizzaParola.Analizza(textToAnalyze);
        // AnalizzaParola.Analizza(textToAnalyze, out bool hasVowels);
        // Console.WriteLine($"what character do you want to count in the text?\n");
        // char characterToCount = Console.ReadKey().KeyChar;
        // AnalizzaParola.Analizza(textToAnalyze, characterToCount);

        //---------------------------------------------------Esempio Array---------------------------------------------------
        // EsempiArray.ModificaArray();
        // EsempiArray.ModificaMatrice();

        // Random random = new Random();
        // int randomNumber = random.Next(0, 101); // genera un numero casuale tra 0 e 100
        // Console.WriteLine($"Numero casuale generato: {randomNumber}");

        /// <summary>
        /// Esercizio crea array 1
        /// </summary>
        // Console.WriteLine($"inserisci la lunghezza dell'array:");
        // int lunghezzaArray = Convert.ToInt32(Console.ReadLine()); // fa la stessa cosa
        // int[] confronto = EsempiArray.creaArray(lunghezzaArray);
        // Console.WriteLine($"The sum of the values in the array is: {Calcolatrice.Somma(confronto)}");


        /// <summary>
        /// Esercizio 2
        /// </summary>

        // int [] confronto = EsempiArray.createCasualArray();
        // EsempiArray.maxValueArray(confronto);
        // EsempiArray.minValueArray(confronto);

        ///<summary>
        ///Esercizio 3
        ///</summary>

        // Console.WriteLine($"inserisci la lunghezza dell'array:");
        // int lunghezzaArray = Convert.ToInt32(Console.ReadLine()); // fa la stessa cosa
        // int[] confronto = EsempiArray.creaArray(lunghezzaArray);
        // Console.WriteLine($"what value do u want to search?");
        // int value = Convert.ToInt32(Console.ReadLine());
        // EsempiArray.searchItemInArray(confronto,value);
        // int[] yarra = EsempiArray.reverseArray(confronto);
        // Console.WriteLine($"array not reversed");
        // for (int i = 0; i < confronto.Length; i++) Console.WriteLine($"{confronto[i]}");
        // Console.WriteLine($"reversed array");
        // for (int i = 0; i < yarra.Length; i++) Console.WriteLine($"{yarra[i]}");
        
        

    }



}

