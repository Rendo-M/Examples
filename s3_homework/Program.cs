
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("*** ЗАДАЧА #1 ***");


bool IsPalindrom(int number)
{
    int num = number;
    int reversed = 0;
    while (num > 0)
    {
        reversed = reversed * 10 + num % 10;
        num /= 10;
    } 
    return reversed == number;
}


Console.Write("Enter the Number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (IsPalindrom(num))
{
    Console.WriteLine($"{num} Это палиндром");
}
else
{
    Console.WriteLine($"{num} Это не палиндром");
}



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("*** ЗАДАЧА #2 ***");


double LenSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x1 - x2;
    double dy = y1 - y2;
    double dz = z1 - z2;
    return Math.Sqrt(dx*dx + dy*dy + dz*dz);
    
}


Console.Write("Введите х координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 1 точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x координату 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 2 точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Длина отрезка ({x1},{y1},{z1}) ({x2},{y2},{z2}) равна {LenSegment(x1, y1, z1, x2, y2, z2)}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("*** ЗАДАЧА #3 ***");

void QubeTable(int n)
{   
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"куб числа {i} = {Math.Pow(i,3)}");
        i++;
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
QubeTable(number);