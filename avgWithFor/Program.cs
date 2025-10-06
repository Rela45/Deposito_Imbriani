// Scrivi un programma che chieda all'utente quanti numeri interi vuole inserire. Il
// programma acquisisce i numeri e alla fine calcola e stampa la loro media

Console.WriteLine($"How many numbers do u want to insert?");
int count = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Insert number {i + 1}:");
    int number = Convert.ToInt32(Console.ReadLine());
    sum += number;
}
Console.WriteLine($"The average is: { (float)sum / count }");