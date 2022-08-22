//Напишите программу, которая принимает на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.

bool IsMultiple(int number, int divider1, int divider2)
{   
    return (number % divider1 == 0)&&(number % divider2 == 0);
}

Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (IsMultiple(x, 7, 23))
{
    Console.WriteLine("ОНО ДЕЛИТСЯ!");
}
else
{
    Console.WriteLine("Не делится ):");
} 

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
 bool IsSquare(int num1, int num2)
 {
    return (num1 * num1 == num2)||(num2 * num2 == num1);
 }

 int first = new Random().Next(1,50);
 int second = new Random().Next(1,50);
 if (IsSquare(first, second)){
 Console.WriteLine($"one of nubmers {first} and {second} is square of anoter"); 
 }
 else
 {
Console.WriteLine($"no one of nubmers {first} and {second} is square of anoter"); 
 
 }