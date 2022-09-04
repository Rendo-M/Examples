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

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int CountEven(int [] arr)
{   
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
          counter += arr[i] % 2; 
    return arr.Length - counter;
}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int SumOddPos(int [] arr)
{
    int sumOdd = 0;
    for (int i= 1; i < arr.Length; i += 2)
        sumOdd += arr[i];
    return sumOdd;
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double MinMaxDifference(double [] arr)
{
    int minPos = 0;
    int maxPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[minPos] > arr[i]) 
            minPos = i;
        else if (arr[maxPos] < arr[i])
            maxPos = i;    
    }
    return arr[maxPos] - arr[minPos];
}


void TestTask1(int minN, int maxN, int minVal, int maxVal)
{
    int  lenArr = new Random().Next(minN, maxN);    
    int [] newArray = CreateRandomArray(lenArr, minVal, maxVal);
    Console.Write("В массиве: ");
    PrintArray(newArray);
    Console.WriteLine($"четных элементов: {CountEven(newArray)}");
}


void TestTask2(int minN, int maxN, int minVal, int maxVal)
{
    int  lenArr = new Random().Next(minN, maxN);    
    int [] newArray = CreateRandomArray(lenArr, minVal, maxVal);
    Console.Write("Сумма элементов массива: ");
    PrintArray(newArray);
    Console.WriteLine($"на нечетных позициях: {SumOddPos(newArray)}");
}





void TestTask3(int minN, int maxN, int minVal, int maxVal)
{
int  lenArr = new Random().Next(minN, maxN);    
double [] newArr = CreateRandomDoubleArray(lenArr, minVal, maxVal);
Console.Write("Разность максимального и минимального элементов массива: ");
PrintDoubleArray(newArr);
Console.WriteLine($"сотставляет: {MinMaxDifference(newArr):f2}");
}


void TestTask(int taskNumber, int [] sizeMinMax, int [] elemMinMax)
{   Console.ForegroundColor = (ConsoleColor)(2); 
    if (taskNumber == 1)
    {
       Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
       Console.ResetColor();
       TestTask1(sizeMinMax[0], sizeMinMax[1], elemMinMax[0], elemMinMax[1]); 
    }
    else if (taskNumber == 2)
    {
       Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
       Console.ResetColor();
       TestTask2(sizeMinMax[0], sizeMinMax[1], elemMinMax[0], elemMinMax[1]); 
    }
    else if (taskNumber == 3)
    {
       Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.ResetColor();
       TestTask3(sizeMinMax[0], sizeMinMax[1], elemMinMax[0], elemMinMax[1]); 
    }
    else
        Console.WriteLine("Некорректный номер задачи");
        Console.ResetColor();

}


int [] nMinMax =  {5, 10}; // мин и макс возможный размер массива
int [] elementsMinMax =  {100, 999}; // мин и макс возможный элемент массива

TestTask(1,nMinMax, elementsMinMax);
TestTask(2,nMinMax, elementsMinMax);
TestTask(3,nMinMax, elementsMinMax);