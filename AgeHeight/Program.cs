Console.WriteLine($"how old are u? ");
string? input1 = Console.ReadLine();
if (string.IsNullOrEmpty(input1))
{
    Console.WriteLine("You did not enter a number!");
    return;
}
int age = int.Parse(input1);
Console.WriteLine($"how tall are u? (in meters) ");
string? input2 = Console.ReadLine();
if (string.IsNullOrEmpty(input2))
{
    Console.WriteLine("You did not enter a number!");
    return;
}
float height = float.Parse(input2);

int sum = age + (int)height;
Console.WriteLine($"sum of your age and height is: {sum}  ");


