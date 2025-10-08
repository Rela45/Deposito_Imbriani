using System;
using System.Runtime.CompilerServices;

class CodiceVolo
{
    public int codVolo;

    public CodiceVolo(int codVolo)
    {
        this.codVolo = codVolo;
    }
}

class VoloAereo : CodiceVolo
{
    private int postiOccupati;
    const int MAX_POSTI = 150;

    public VoloAereo(int codVolo) : base(codVolo)
    {
        this.postiOccupati = 0;
    }
    

    public int PostiOccupati()
    {
        return postiOccupati;
    }

    public int PostiLiberi()
    {
        return MAX_POSTI - postiOccupati;
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (PostiLiberi() >= numeroPosti)
        {
            postiOccupati += numeroPosti;
            Console.WriteLine($"Prenotazione effettuata correttamente");
            
        }
        else
        {
            Console.WriteLine("Non ci sono abbastanza posti disponibili");
        }
    }

    public void RimuoviPrenotazione(int numeroPosti)
    {
        if (PostiOccupati() > 0)
        {
            postiOccupati -= numeroPosti;
            Console.WriteLine($"Prenotazione annullata");
        }
        else
        {
            Console.WriteLine($"Non hai effettuato alcuna prenotazione");
            
        }
    }
    public void VisualizzaStato()
    {
        Console.WriteLine($"Volo: {codVolo}, Posti occupati: {PostiOccupati()}, Posti liberi: {PostiLiberi()}");
    }


    class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int codVolo = random.Next(1, 5);
            
            VoloAereo voloAereo = new VoloAereo(codVolo);
            bool continua = true;
            int scelta = 0;
            while (continua)
            {
                Console.WriteLine("1. Visualizza stato voli\n2. Effettua prenotazione\n3. Rimuovi prenotazione\n4. Esci");

                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        voloAereo.VisualizzaStato();
                        break;
                    case 2:
                        Console.WriteLine($"quanti posti vuoi prenotare?");
                        int input = Convert.ToInt32(Console.ReadLine());
                        voloAereo.EffettuaPrenotazione(input);
                        break;
                    case 3:
                        Console.WriteLine($"quanti posti vuoi rimuovere?");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        voloAereo.RimuoviPrenotazione(input2);
                        break;
                    case 4:
                        Console.WriteLine($"fine");
                        continua = false;
                        break;
                        
                }
            }
        }
    }
}


