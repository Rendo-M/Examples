// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input positive int number: ");
Int32 num = Convert.ToInt32(Console.ReadLine());
Int32 counter = 2;
Console.WriteLine($"Even numbers from 1 to {num}:");
while (counter <= num)
{
Console.Write(counter+" ");
counter += 2;
}