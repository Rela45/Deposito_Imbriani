using System;



class PrenotazioneViaggio
{
    private int postiPrenotati;
    private const int MAX_POSTI = 20;

    public string Destinazione { get; set; }

    public int PostiLiberi()
    {
        return MAX_POSTI - postiPrenotati;
    }


    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (PostiLiberi() >= numeroPosti)
        {
            postiPrenotati += numeroPosti;
            Console.WriteLine($"Prenotazione effettuata correttamente");

        }
        else
        {
            Console.WriteLine("Non ci sono abbastanza posti disponibili");
        }
    }
    public void RimuoviPrenotazione(int numeroPosti)
    {
        if (postiPrenotati > 0)
        {
            postiPrenotati -= numeroPosti;
            Console.WriteLine($"Prenotazione annullata");
        }
        else
        {
            Console.WriteLine($"Non hai effettuato alcuna prenotazione");
        }
    }

    public int PostiPrenotati
    {
        get { return postiPrenotati; }
    }
    public void VisualizzaStato()
    {
        Console.WriteLine($" Posti occupati: {postiPrenotati}, Posti liberi: {PostiLiberi()}");
    }
}




class Program
{
    static void Main(string[] args)
    {
        bool continua = true;   
        PrenotazioneViaggio prenotazione = new PrenotazioneViaggio();
        

        while (continua)
        {
            Console.WriteLine($"Premi: \n1 per aggiungere una destinazione \n2 per prenotare il viaggio \n3 per annullare una prenotazione\n4 per visualizzare i posti ancora disponibili\n5 per uscire dall'applicazione");
            int scelta = Convert.ToInt32(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Aggiungi una destinazione");
                    prenotazione.Destinazione = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine($"quanti posti vuoi prenotare?");
                    int input = Convert.ToInt32(Console.ReadLine());
                    prenotazione.EffettuaPrenotazione(input);
                    break;
                        
                case 3:
                        Console.WriteLine($"quanti posti vuoi rimuovere?");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        prenotazione.RimuoviPrenotazione(input2);
                        break;
                case 4:
                        prenotazione.VisualizzaStato();
                        break;
                case 5:
                        Console.WriteLine($"fine");
                        continua = false;
                        break;
                }
        }
    }
}
