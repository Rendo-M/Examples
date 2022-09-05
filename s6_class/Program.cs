int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}


double [] CreateRandomDoubleArray(int n, int minVal, int maxVal)
{
 double [] arr = new double[n];
 Random rng = new Random();
 for (int i = 0; i < n; i++) 
 {
    arr[i] = rng.Next(minVal, maxVal)+ rng.NextDouble();
 }
 return arr;
}


void PrintDoubleArray(double [] arr)
    
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    { 
      Console.ForegroundColor = (ConsoleColor)(5 + i % 2);    
      Console.Write($"{arr[i]:f2}; ");
    }  Console.ResetColor();
       Console.WriteLine($"\b\b]");  
}


void PrintArray(int [] arr)
    
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    { 
      Console.ForegroundColor = (ConsoleColor)(5 + i % 2);    
      Console.Write($"{arr[i]}; ");
    }  Console.ResetColor();
       Console.WriteLine($"\b\b]");  
}




void TestTask1(int minN, int maxN, int minVal, int maxVal)
{
    int  lenArr = new Random().Next(minN, maxN);    
    int [] newArray = CreateRandomArray(lenArr, minVal, maxVal);
    Console.Write("Исходный массив:    ");
    PrintArray(newArray);
    Console.WriteLine();
    ReverseArray(newArray);
    Console.Write("Развернутый массив: ");
    PrintArray(newArray);
    Console.WriteLine();
}

void ReverseArray(int [] arr)
{ 
    int temp = 0;
    for (int i = 0, j = arr.Length-1; i < j; i++, j--)
    {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }    

}
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Dec2Bin(int num)
{   
    string binNum = "";
    while (num > 0)
    {
        binNum = Convert.ToString(num % 2) + binNum;
        num /= 2;
    }
    return binNum;
}

void TestTask2(int minNum, int maxNum)
{
  int num = new Random().Next(minNum, maxNum);   
  Console.WriteLine($" Число {num} в двоичной системе счисления {Dec2Bin(num)} ");
  
}


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
int [] Fibo(int a, int b, int n)
{

 int [] sequence = new int [n];
 sequence[0] = a;
 sequence[1] = b;
 for (int i = 2; i < n; i++)
     sequence[i] = sequence[i-1] + sequence[i-2];
 return sequence;
 }

void TestTask3(int a, int b, int minN, int maxN)
{
    Console.Write($" Последовательность Фибоначи начинающаяся с чисел {a} {b}: ");
    PrintArray(Fibo(a, b, new Random().Next(minN, maxN+1)));
    Console.WriteLine();
}



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник сo сторонами такой длины.
bool IsTriangle(int a, int b, int c )
{
    return (Math.Max(Math.Max(a, b),c) < a + b + c - Math.Max(Math.Max(a, b),c));
}

void TestTask4(int minN, int maxN)
{   
    int a = new Random().Next(minN, maxN);
    int b = new Random().Next(minN, maxN);
    int c = new Random().Next(minN, maxN);
    Console.Write($" Числа {a} {b} {c}: ");
    if (IsTriangle(a, b, c))
        Console.WriteLine("являются сторонами треугольника");
    else
        Console.WriteLine("не являются сторонами треугольника");    
    Console.WriteLine();
}


Console.Clear();

TestTask1(4, 10, 5, 25);   
TestTask2(5, 10);   
TestTask3(1, 1, 4, 10);   
TestTask4(3, 7);