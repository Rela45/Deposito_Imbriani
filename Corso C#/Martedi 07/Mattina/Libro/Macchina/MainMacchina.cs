
using System;
class MainMacchina
{
    public static void Main()
    {
        Random random = new Random();
        int credGiovanni = random.Next(1, 5);
        int credAndrea = random.Next(1, 5);
        int credMario = random.Next(1, 5);

        Utente Giovanni = new Utente("Giovanni", credGiovanni);
        Utente Mario = new Utente("Mario", credMario);
        Utente Andrea = new Utente("Andrea", credAndrea);

        Macchina Fiat = new Macchina("Fiat", 5, 160, 0);
        Macchina BMW = new Macchina("BMW", 10, 200, 2);
        Macchina Audi = new Macchina("Audi", 15, 220, 3);
        

        bool continua = true;

        while (continua)
        {
            Console.WriteLine($"sono qui");
            
            continua = false;
        }
        
    } 
}