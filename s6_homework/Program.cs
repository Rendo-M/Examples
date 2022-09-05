
void PrintArray(int [] arr)
    
{   Console.Write($"");
    for(int i = 0; i < arr.Length; i++)
    { 
      Console.ForegroundColor = (ConsoleColor)(5 + i % 2);    
      Console.Write($"{arr[i]}; ");
    }  Console.ResetColor();
       Console.WriteLine($"\b\b");  
}

void PrintDoubleArray(double [] arr)
    
{   Console.Write($"");
    for(int i = 0; i < arr.Length; i++)
    { 
      Console.ForegroundColor = (ConsoleColor)(5 + i % 2);    
      Console.Write($"{arr[i]:f1}; ");
    }  Console.ResetColor();
       Console.Write($"\b\b - ");  
}

void PrintMatrix(double [,] mx)
{
for (int j = 0; j < mx.GetLength(0); j++)
        {   
            for (int k = 0; k < mx.GetLength(1); k++)
                Console.Write($"{mx[j, k]:f1} ");
            Console.WriteLine();  
        }
        Console.WriteLine();
}


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositiveNumbers(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        count += Convert.ToInt32(arr[i] > 0);
    }
    return count;
}



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double [,] GaussForward( double [,] matrix, bool showIter=false)
{   
    double k0 = 0;
    for (int t = 0; t < matrix.GetLength(0); t++)
    {
        k0 = matrix[t, t];
        for (int i = t; i < matrix.GetLength(1); i++)
            matrix[t,i] = matrix[t,i]/ k0; 
        for (int i = t+1 ; i < matrix.GetLength(0); i++)
        {
            k0 = - matrix[i,t];    
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = matrix[i, j] + matrix[t, j] * k0;  
            }
        }
        if (showIter)
            PrintMatrix(matrix);
    }
    return matrix;
}

double [] GaussBackward(double [,] matrix, bool showIter=false)
{
    double x = 0;
    int n = matrix.GetLength(0);
    for (int i = matrix.GetLength(0)-1; i > 0; i--)
    {   
        x = matrix[i, n];
        for (int j = i - 1; j >= 0 ; j--)
        {
            matrix[j, n] = matrix[j, n] - x * matrix[j, i];
            matrix[j, i] = 0;

        }
        if (showIter)
            PrintMatrix(matrix);
    }
    double []  answers = new double [n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        answers[i] = matrix[i, n];
    }
    return answers;
}





void TestGauss3(int order=3)
{
    double [,] mx = {{3, 2, -5, -1},
                     {2, -1, 3, 13},
                     {1, 2, -1, 9}};

    double [,] mx4 = {{1, -1, 3, 1, 5},
                      {4, -1, 5, 4, 4},
                      {2, -2, 4, 1, 6},
                      {1, -4, 5, -1, 3}};
    
    if (order==3)
    {
        PrintMatrix(mx);
        mx = GaussForward(mx, true);
        PrintMatrix(mx);
        PrintDoubleArray(GaussBackward(mx, true));
    }
    else
    {
        PrintMatrix(mx4);
        mx4 = GaussForward(mx4, true);
        PrintMatrix(mx4);
        PrintDoubleArray(GaussBackward(mx4, true));
    }
    Console.WriteLine("Корни системы уравнений: ");
}



void TestTask1()
{
Console.Write("Сколько чисел будет вводиться? ");
int [] newArr = new int [Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < newArr.Length; i++)
{
    Console.Write($"Введите число №{i+1}: ");
    newArr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("В последовательности чисел: ");
PrintArray(newArr);
Console.Write($"{CountPositiveNumbers(newArr)} положительных");
}


void TestTask2()
// Нахождение точки пересечения прямых эквивалентно решению системы уравнений

{   double [,] arr = new double [2, 3];
    arr[0,1] = -1;
    arr[1,1] = -1;
    Console.Write("Enter k1 (5) : ");
    arr[0,0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter b1 (2) : ");
    arr[0,2] = - Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter k2 (9) : ");
    arr[1,0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter b2 (4) : ");
    arr[1,2] = - Convert.ToDouble(Console.ReadLine());
    arr = GaussForward(arr);
    PrintDoubleArray(GaussBackward(arr));
    Console.WriteLine(" точка пересечения ");
    }


Console.Clear(); 
TestTask2();
//TestGauss3(); // Тестовое решение системы из 3(4) уравнений
// TestTask1();