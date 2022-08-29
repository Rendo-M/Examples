// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNumbers(int num)
{   int result = 0;
    for(int i = 1; i<= num; i++)
        result += i;
    return result;    
} 

// Console.WriteLine($"Сумма чисел от 0 до {n} равна {SumNumbers(n)}");

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int CountDigits(int num)
{ int result = 0;
while (num > 0)
{
    result++;
    num /= 10;
} 
    return result;
}


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int MultNumbers(int num)
{
    int multi = 1;
    for (int i = num; i > 0; i--)
    multi *= i;
    return multi;
}


Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"multiplication of numbers from 1 to {n} is {MultNumbers(n)}");


//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}

void PrintArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
}

PrintArray(CreateRandomArray(8, 0, 1));
PrintArray(CreateRandomArray(8, 0, 1));

int [] newArr = CreateRandomArray(8, 0, 1);
PrintArray(newArr);
PrintArray(newArr);
