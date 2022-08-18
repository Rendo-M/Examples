// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input int number to check even it or no: ");
Int32 num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is even");
}
else
{
    Console.WriteLine($"{num} not even");
}