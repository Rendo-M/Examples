// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Power1(int num, int n)
{   
    int pow = num;
    for (int i = 1; i < n; i++)
    {
        pow *= num;
    }
    return pow;
}

int Power2(int num, int n)
{   if (n > 2) 
        num = Power2(num, n-1) * num;
    else 
        num = num * num;
    return num;
}


int a = new Random().Next(0, 10);
int b = new Random().Next(0, 10);
Console.WriteLine($"Power1:   {a} в степени {b} = {Power1(b, a)}");
Console.WriteLine($"Power2:   {a} в степени {b} = {Power2(b, a)}");
Console.WriteLine($"Math.Pow: {a} в степени {b} = {Math.Pow(b, a)}");
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int CalcDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    } 
    return result;
}


a = new Random().Next(10, 100000);
Console.WriteLine($"Сумма цифр числа {a} = {CalcDigits(a)}");


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintArray(int [] arr)
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}

int [] CreateArray(int n)
{   
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter {i+1} element: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return arr;
}

int [] arr = CreateArray(new Random().Next(5, 10));
PrintArray(arr);