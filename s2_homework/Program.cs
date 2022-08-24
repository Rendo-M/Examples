// вспомогательный метод для задач 1 и 2:
int GetDigitByPos(int number, int position)
// return digit of any number by its position
{   int divider = Convert.ToInt32(Math.Pow(10,position));
    return number % divider*10 / divider;
    
}


// Задача 1:
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Enter the Number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"second digit of {num} is {GetDigitByPos(num, 2)}");


// Задача 2:
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
void ThirdDigit( int num)
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{   if ((num < 100)&&(num > -100))
    {
        Console.WriteLine($"No third digit in {num}");
    }
    else
    {
    int n = num;    
    while  (Math.Abs(n / 1000) > 0)
    {
        n = n / 10;
    }

      Console.WriteLine($"Third digit of {num} is {Math.Abs(n % 10)}");
    }
}


ThirdDigit(num);


// Задача 3:
// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным

string IsHoliday(int day)
{
    if (day > 5)
    { 
        return "Да";
    }
    return "Нет";
}

Console.Write("Введите номер дня недели(1-пн, 2-вт, 3-ср, 4-чт, 5-пт, 6-сб, 7-вс): ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Является ли {day} день выходным? Определенно {IsHoliday(day)}");
