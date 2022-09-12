void PrintArray(int [] arr)
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    { 
      Console.ForegroundColor = (ConsoleColor)(5 + i % 2);    
      Console.Write($"{arr[i]}; ");
    }  
    Console.ResetColor();
    Console.WriteLine($"\b\b]");  
}

void PrintMatrix(int [,] mx)
{
for (int j = 0; j < mx.GetLength(0); j++)
        {   
            Console.Write($"[");
            for (int k = 0; k < mx.GetLength(1); k++)
            {    
                Console.ForegroundColor = (ConsoleColor)(5 + (j+k) % 2);
                Console.Write($"{mx[j, k]}; ");
                Console.ResetColor();
            }
            Console.WriteLine($"\b\b]");
        }
        Console.WriteLine();
}

int [] CreateRandomArray(int n, int minVal, int maxVal)
{
   
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
     arr[i] = new Random().Next(minVal, maxVal+1);
  return arr;
}


int [,] CreateRandomMatrix(int n, int m, int minVal, int maxVal)
{
 int [,] arr = new int[n, m];
 for (int i = 0; i < n; i++) 
    for (int j = 0; j < m; j++)
        arr[i, j] = new Random().Next(minVal, maxVal+1);   
 return arr;
}



//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.


int [,] MatrixFilledSumIndex(int n, int m)
{
 int [,] arr = new int[n, m];
 for (int i = 0; i < n; i++) 
    for (int j = 0; j < m; j++)
        arr[i, j] = i+j;   
 return arr;
}

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int [,] ChangeEvensToSquareMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0) ; i+=2)
        for (int j = 0; j < arr.GetLength(1); j+=2)
            arr[i,j] = arr[i,j]*arr[i,j];
    return arr;        
}


int [,] NewMatrixEvensToSquare(int [,] arr)
{
    int [,] newMatrix = new int [arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0) ; i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i % 2 ==0 && j % 2 == 0)
                newMatrix[i,j] = arr[i,j]*arr[i,j];
            else 
                newMatrix[i,j] = arr[i,j];
    return newMatrix;        
}
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int SumMainDiag(int [,] matrix)
{   
    int sum = 0;
    for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}

// Найти строку с наименьшей суммой элементов двумерного массива
int FindRowLowestSum(int [,] arr)
{
    int numRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {   sumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sumRow += arr[i,j];
        if (i == 0)
            minSumRow = sumRow;
        else if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            numRow = i;    
        }
    }    
    return numRow;    
}


Console.Clear();

Console.Write("Enter number of rows pls: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns pls: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min value for element of matrix: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value for element of matrix: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int [,] newArray = CreateRandomMatrix(rows, cols, minVal, maxVal);
PrintMatrix(newArray);
Console.WriteLine($"строка с наименьшей суммой {FindRowLowestSum(newArray)}");