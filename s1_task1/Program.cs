// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number: ");
Int32 number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
Int32 number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"first number {number1} more then second {number2}");    
}
else
if (number1 < number2)
    Console.WriteLine($"second number {number2} more then first {number1}");    
else
    Console.WriteLine($"first number {number1} equival second {number2}");    
