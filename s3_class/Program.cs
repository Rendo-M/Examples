int GetQuadrant(double x, double y)
// возвращает номер координатной четверти, в которой лежит точка (х, у)
{
   if(x > 0 && y > 0) return 1;
   if(x < 0 && y > 0) return 2;
   if(x < 0 && y < 0) return 3;
   if(x > 0 && y < 0) return 4;
   return 0;
}







//Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).


void CoordByQuadrant(int quadrant)
{   string output = "некорректный ввод данных";
    if (quadrant == 1) 
    output = $"Для четверти {quadrant} x > 0 у > 0";
    if (quadrant == 2) 
    output = $"Для четверти {quadrant} x < 0 у > 0";
    if (quadrant == 3) 
    output = $"Для четверти {quadrant} x < 0 у < 0";
    if (quadrant == 4) 
    output = $"Для четверти {quadrant} x > 0 у < 0";
    Console.WriteLine(output);
}
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
void SquaresTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"квадрат числа {i} = {i*i}");
        i++;
    }
}

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

double LenSegment(double x1, double y1, double x2, double y2)
{
    double dx = x1 - x2;
    double dy = y1 - y2;
    return Math.Sqrt(dx*dx + dy*dy);
    
}
/*
Console.Write("Введите номер четверти: ");
int quad = Convert.ToInt32(Console.ReadLine());
CoordByQuadrant(quad);
SquaresTable(quad);
*/


Console.Write("Введите х координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите х координату 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Длина отрезка ({x1},{y1}) ({x2},{y2}) равна {LenSegment(x1, y1, x2, y2)}");
