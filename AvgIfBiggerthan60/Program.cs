Console.WriteLine($"Text 3 integer number");
Console.WriteLine($"first one: ");
string? input1 = Console.ReadLine();
if (string.IsNullOrEmpty(input1))
{
    Console.WriteLine("You did not enter a number!");
    return;
}
int number1 = int.Parse(input1);
double castedNumber1 = (double)number1;
Console.WriteLine($"second one: ");
string? input2 = Console.ReadLine();
if (string.IsNullOrEmpty(input2))
{
    Console.WriteLine("You did not enter a number!");
    return;
}
int number2 = int.Parse(input2);
double castedNumber2 = (double)number2;
Console.WriteLine($"third one: ");
string? input3 = Console.ReadLine();
if (string.IsNullOrEmpty(input3))
{
    Console.WriteLine("You did not enter a number!");
    return;
}
int number3 = int.Parse(input3);
double castedNumber3 = (double)number3;

double average = (castedNumber1 + castedNumber2 + castedNumber3) / 3;
if (average > 60)
{
    Console.WriteLine($"u passed the exam");
    Console.WriteLine($"The average between {number1}, {number2} and {number3} is: {average} ");
}
else
{
    Console.WriteLine($"Text u failed the exam");
    Console.WriteLine($"The average is less than 60");
}