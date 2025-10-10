namespace GestionaleCorsi
{
    public abstract class Corso
    {
        public string Titolo { get; set; }
        private int _durataOre;
        public int DurataOre { get => _durataOre ; set
            {
                if (value > 0) DurataOre = value;
            }
        }

        protected Corso(string titolo, int durata)
        {
            Titolo = titolo;
            DurataOre = durata;
        }
        public abstract void ErogaCorso();
        public abstract void stampaDettagli();
    }
}
