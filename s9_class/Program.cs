// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNumbers(int n)
{
    
    Console.Write($"{n} ");
    if (n > 1)
        ShowNumbers(n-1);
    Console.Write($"{n} ");
        
}

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumDigits(int num)
{
    if (num > 9)
        return num % 10 + SumDigits(num /10);
    else
        return num;
}

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNumbersDiap(int n, int m)
{
    
    Console.Write($"{Math.Max(n,m)} "); 
    if (Math.Max(n,m) != Math.Min(n,m))
        ShowNumbersDiap(Math.Max(n,m)-1, Math.Min(n,m));
       
        
}


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

double PowerUp(double x, int pow)
{ 
  
  if (pow < 0)
  {
    x = 1 / x;
    pow = -pow;
  }
  if (pow != 0) return  x*PowerUp(x, pow-1);
  else
    return 1;  
}




Console.WriteLine(PowerUp(2,-2));

//ShowNumbersDiap(-17, -3);

//Console.WriteLine();
//Console.WriteLine(SumDigits(54123));
