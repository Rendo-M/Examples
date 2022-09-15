//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNumbersRange(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n,m))
        ShowNumbersRange(Math.Max(n,m)-1, Math.Min(n,m));
    
    Console.Write($"{Math.Max(n,m)} ");    
        
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbersRange(int n, int m)
{
    
     
    if (Math.Max(n,m) != Math.Min(n,m))
        return Math.Max(n,m) + SumNumbersRange(Math.Max(n,m)-1, Math.Min(n,m));
    else
        return m;   
        
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman(int m, int n)
{
    if (m == 0)
        return n+1;
    if (m > 0)
        {
        if (n == 0)
            return Akkerman(m-1, 1);
        return Akkerman(m-1, Akkerman(m,n-1));    
        }
    return 0;    

}

Console.WriteLine(Akkerman(3, 5));
ShowNumbersRange(-10, 1);