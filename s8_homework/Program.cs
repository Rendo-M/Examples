void TestTask4()
{
    Console.Clear();
    Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");    
    Console.Write("Enter number for rows: ");
    int firstDim = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number for columns: ");
    int secondDim = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number for depth: ");
    int thirdDim = Convert.ToInt32(Console.ReadLine());
    if (firstDim*secondDim*thirdDim < 90)
    {    
        int [,,] matrix = Create3DimensionMatrix(firstDim,secondDim,thirdDim);
        Print3DMatrix(matrix);
    }    
    else
        Console.WriteLine("Too large matrix");
}

void TestTask5()
{

    Console.Clear();
    Console.WriteLine("Напишите программу, которая заполнит спирально массив");       
    Console.Write("Enter number for rows: ");
    int firstDim = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number for columns: ");
    int secondDim = Convert.ToInt32(Console.ReadLine());
    int [,] matrix = FillSpiralledMatrix(firstDim,secondDim);
    PrintMatrix(matrix);
}    

void TestTask1()
{
    Console.Clear();
    Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] newArr = CreateRandomMatrix(rows, cols, minVal, maxVal);
    Console.WriteLine("Initial matrix: ");
    PrintMatrix(newArr);
    Console.WriteLine("Sorted matrix: ");
    newArr = SortRows(newArr);
    PrintMatrix(newArr);
}    

void TestTask2()
{
    Console.Clear();
    Console.WriteLine(" Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] newArr = CreateRandomMatrix(rows, cols, minVal, maxVal);
    Console.WriteLine("Initial matrix: ");
    PrintMatrix(newArr);
    Console.WriteLine($"Row with lovest sum: {FindRowLowestSum(newArr)}");
}    

void TestTask3()
{
    Console.Clear();
    Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.Write("Enter number of rows in first matrix: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns in first matrix: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns in second matrix: ");
    int cols2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] matrix1 = CreateRandomMatrix(rows, cols, minVal, maxVal);
    Console.WriteLine("First matrix: ");
    PrintMatrix(matrix1);
    int [,] matrix2 = CreateRandomMatrix(cols, cols2, minVal, maxVal);
    Console.WriteLine("Second matrix: ");
    PrintMatrix(matrix2);
    Console.WriteLine("Product matrix: ");
    int [,] newArr = MatrixMultiple(matrix1, matrix2);
    PrintMatrix(newArr);
}   

void Print3DMatrix(int [,,] mx)
{
for (int i = 0; i < mx.GetLength(2); i++)
    {
    Console.WriteLine($" third dim slice {i}");    
    for (int j = 0; j < mx.GetLength(0); j++)
            {   
                Console.Write($"[");
                for (int k = 0; k < mx.GetLength(1); k++)
                {    
                    Console.ForegroundColor = (ConsoleColor)(5 + 4*(j % 2) + (j+k) % 2);
                    Console.Write($"{mx[j, k, i]}; ");
                    Console.ResetColor();
                }
                Console.WriteLine($"\b\b]");
            }
            Console.WriteLine();
    }
}        

void PrintMatrix(int [,] mx)
{
for (int j = 0; j < mx.GetLength(0); j++)
        {   
            Console.Write($"[");
            for (int k = 0; k < mx.GetLength(1); k++)
            {    
                Console.ForegroundColor = (ConsoleColor)(5 + 4*(j % 2) + (j+k) % 2);
                Console.Write($"{mx[j, k]:d2}; ");
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




// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] SortRows(int [,] matrix)
{
    int maxIndex, temp;
    for (int k = 0; k < matrix.GetLength(0); k++)
        for (int i = 0; i < matrix.GetLength(1); i++)
        {   
            maxIndex =  i;
            for (int j = i+1; j < matrix.GetLength(1); j++)
                if (matrix[k,j] > matrix[k, maxIndex])
                    maxIndex  = j;
            temp = matrix[k, maxIndex];
            matrix[k, maxIndex] = matrix[k, i];
            matrix[k,i] = temp;
    }
    return matrix;
}



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int FindRowLowestSum(int [,] arr)
{
    int numRow = 0;
    int minSumRow = 0;
    int sumRow;
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
    return numRow+1;    
}

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] MatrixMultiple(int[,] mx1, int [,] mx2)
{
    int sum =0;
    int [,] res = new int [mx1.GetLength(0), mx2.GetLength(1)];
    if (mx1.GetLength(1) != mx2.GetLength(0))
        return res;
    for (int i = 0; i < res.GetLength(0); i++)
        for (int j = 0; j < res.GetLength(1); j++)
            for (int k = 0; k < mx2.GetLength(0); k++)
                res[i,j] += mx1[i,k]*mx2[k,j];
    return res;                
}

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
var rngNumbers = new List<int>(90);
for (int i = 0; i < 90; i++)
    rngNumbers.Add(i+10);

// в принципе можно делать все то же самое с массивом на 90 элементов, помечая забранные, и фмксируя, сколько забарли,
// но раз уж появилась возможность и смысл в том, чтобы посмотреть в сторону списков, почему бы не сделать это.
int GenerateNumber()
{
    int  number =  rngNumbers[new Random().Next(0, rngNumbers.Count)]; 
    rngNumbers.Remove(number);
    return number;
}

int [,,] Create3DimensionMatrix(int firstDim, int secondDim, int thirdDim)
{
    int [,,] newMatrix = new int [firstDim, secondDim, thirdDim];
    for (int i = 0; i < firstDim; i++)
        for (int j = 0; j < secondDim; j++)
            for (int k = 0; k < thirdDim; k++)
                newMatrix[i,j,k] = GenerateNumber();
    return newMatrix;            
}


// Напишите программу, которая заполнит спирально массив 4 на 4. 
bool InBorders(int posR, int posC, int rows, int cols)
{    
    return ((posR >= 0)&&(posR < rows)&&(posC >= 0)&&(posC < cols));
}


int [,] FillSpiralledMatrix(int dimRow, int dimCol)
{
    int [,] matrix = new int [dimRow, dimCol];
    int dr, dc, row, col, temp;
    dc = 1;
    dr = row = col = temp = 0;
    for (int i = 1; i <= dimRow*dimCol; i++)
    {
        matrix[row,col] = i;
        if (!InBorders(row+dr, col+dc, dimRow, dimCol) || matrix[(row + dr) % dimRow, (col + dc) % dimCol]  > 0)
        {   
            temp = -dr;    
            dr = dc;
            dc = temp;
        }
        row += dr;
        col += dc;
    }
    return matrix;
}


TestTask1();
Console.ReadLine();
TestTask2();
Console.ReadLine();
TestTask3();
Console.ReadLine();
TestTask4();
Console.ReadLine();
TestTask5();
Console.ReadLine();
