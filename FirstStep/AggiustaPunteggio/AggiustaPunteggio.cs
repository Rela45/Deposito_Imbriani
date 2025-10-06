namespace FirstStep.Esempi
{
    public static class AggiustaPunteggio
    {
        public static void Aggiusta(ref int punteggioCorrente, int bonus, ref int totale, ref int turno, out double media)
        {
            media = 0;
            var punteggioIncrementato = punteggioCorrente + bonus;
            if (turno == 3)
            {
                media = totale / 3;
            }
            else
            {
                turno++;
            }
            
        }
    }
}