using Microsoft.VisualBasic;

namespace FirstStep.AggiustaData
{
    public static class AggiustaData
    {
        public static void PassaData(ref int giorno, ref int mese, ref int anno)
        {
            if (giorno > 30)
            {
                giorno = 1;
                mese++;
            }
            if (mese > 12)
            {
                mese = 1;
                anno++;
            }
        }
    }
    
}