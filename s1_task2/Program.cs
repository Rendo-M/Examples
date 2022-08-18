// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Write("Input first int number: ");
Int32 num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
Int32 num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third int number: ");
Int32 num3 = Convert.ToInt32(Console.ReadLine());
// version 2:
int max1 = Math.Max(Math.Max(num1, num2), num3);
Console.WriteLine($"maximum from numbers {num1} {num2} {num3} is {max1}");       


// version 2:
Int32 max2 = num3;
if (num2 > num3)
{
     max2 = num2;
}
if (max2 > num1)
    Console.WriteLine($"maximum from numbers {num1} {num2} {num3} is {max2}");    
else
    Console.WriteLine($"maximum from numbers {num1} {num2} {num3} is {num1}");       
