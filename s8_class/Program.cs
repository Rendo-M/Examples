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


// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] ChangeRows(int [,] array, int row1, int row2)
{   int temp = 0;
    if (Math.Min(row1,row2) >= 0 && Math.Max(row1,row2) < array.GetLength(0)  && row1 != row2) 
        for (int i = 0; i < array.GetLength(1); i++)
        {
            temp = array[row1,i];
            array[row1,i] = array[row2,i];
            array[row2,i] = temp;
        }
    return array;    
}

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int [,] TransponeMatrix(int [,] array)
{
    int temp = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Матрица не квадратная, поменять столбцы со строками невозможно");
        return array;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int [] FindMatrixMinimum(int [,] array)
{
    int [] minPos = {0,0};

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minPos[0], minPos[1]])
            {
                minPos[0] = i;
                minPos[1] = j;
            }
     return minPos;    
}



int [,] DelRowCol(int [,] array, int row, int col)
{
    int [,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int step_r = 0;
    int step_c = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   step_c = 0;
        if (i == row)
        {
            step_r = 1;
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j == col)
        {
            step_c = 1;
            continue;
        }
        newArray[i-step_r,j-step_c] = array[i, j];
        } 
    }
    return newArray;
}



