void PrintDoubleMatrix(double [,] mx)
{
for (int j = 0; j < mx.GetLength(0); j++)
        {   
            Console.Write($"[");
            for (int k = 0; k < mx.GetLength(1); k++)
            {    
                Console.ForegroundColor = (ConsoleColor)(5 + 4*(j % 2) + (j+k) % 2);
                Console.Write($"{mx[j, k]:f2}; ");
                Console.ResetColor();
            }
            Console.WriteLine($"\b\b]");
        }
        Console.WriteLine();
}

void PrintMatrix(int [,] mx)
{
for (int j = 0; j < mx.GetLength(0); j++)
        {   
            Console.Write($"[");
            for (int k = 0; k < mx.GetLength(1); k++)
            {    
                Console.ForegroundColor = (ConsoleColor)(5 + 4*(j % 2) + (j+k) % 2);
                Console.Write($"{mx[j, k]}; ");
                Console.ResetColor();
            }
            Console.WriteLine($"\b\b]");
        }
        Console.WriteLine();
}

int [,] CreateRandomMatrix(int n, int m, int minVal, int maxVal)
{
 int [,] arr = new int[n, m];
 Random rng = new Random();
 for (int i = 0; i < n; i++) 
    for (int j = 0; j < m; j++)
        arr[i, j] = rng.Next(minVal, maxVal + 1);   
 return arr;
}



// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandomDoubleMatrix(int n, int m, int minVal, int maxVal)
{
 double [,] arr = new double[n, m];
 Random rng = new Random();
 for (int i = 0; i < n; i++) 
    for (int j = 0; j < m; j++)
        arr[i, j] = rng.Next(minVal, maxVal)+ rng.NextDouble();   
 return arr;
}


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

string GetElementByPos(double [,] matrix, int row, int col)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > col)
        return Convert.ToString(Math.Round(matrix[row, col],2));
    else
        return("отсутствует");    
}


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double [,] FindColumnMeans(int [,] matrix)
{
    double sum;
    int len = matrix.GetLength(0);
    double [,] mean = new double [1, matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        mean[0, i] = sum / len;
    }
    return mean;
}



void TestTask1()
{   
    Console.Clear();
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    PrintDoubleMatrix(CreateRandomDoubleMatrix(rows, cols, minVal, maxVal));
    
}


void TestTask3()
{   
    Console.Clear();
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] newArr = CreateRandomMatrix(rows, cols, minVal, maxVal);
    PrintMatrix(newArr);
    Console.WriteLine("Средние арифметические элементов по столбцам:");
    PrintDoubleMatrix(FindColumnMeans(newArr));
}


void TestTask2()
{   
    Console.Clear();
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    double [,] newArr = CreateRandomDoubleMatrix(rows, cols, minVal, maxVal);
    PrintDoubleMatrix(newArr);
    Console.Write($"Enter row for search[0..{rows-1}]:  ");
    int rowNum = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter column for search[0..{cols-1}]:  ");
    int colNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Элемент в позиции [{rowNum}, {colNum}] {GetElementByPos(newArr, rowNum, colNum)}");
}

void TestTask()
{
    while (true)
    {
        Console.Write("Enter number of task to test[1..3] or 0 for exit: ");
        string choise = Console.ReadLine();
        if (choise == "1") TestTask1();
        else if (choise == "2") TestTask2();
        else if (choise == "3") TestTask3();
        else if (choise == "0") break;
        else Console.Write("Wrong Input");
    }

}

Console.Clear();
TestTask();