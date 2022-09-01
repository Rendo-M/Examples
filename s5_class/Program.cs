int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}

void PrintArray(int [] arr)
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}
// сумма отрицательных элементов массива
int SumNegativeElements(int [] arr)
{
  int sum = 0;
  for(int i = 0; i < arr.Length; i++)
    if (arr[i] < 0) sum += arr[i];  
  return sum;
}



//Напишите программу для замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ReverseSignElemebts( int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    arr[i]*= -1;
    return arr;
}


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindElem(int [] arr, int number)
{
    for (int i=0; i < arr.Length; i++)
    if (arr[i] == number)
        return true;
    return false;    
} 



// Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int CountInRange(int [] arr, int bottom, int top)
{   
    int count = 0;    
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] <= top)&&(arr[i] >= bottom))
            count++;
    }
    return count;
}

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
int [] MultPairs(int [] arr)
{ 
    int [] newArr = new int [arr.Length /2 + arr.Length % 2]; 
    for (int i = 0; i < (arr.Length /2 + arr.Length % 2); i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArr;
}



int [] arr = CreateRandomArray(15, 0, 150);
PrintArray(arr);
Console.WriteLine(CountInRange(arr, 10, 99));

/*
Console.Write("Какое число ищем? ");
int num = Convert.ToInt32(Console.ReadLine());
if (FindElem(arr, num))
    Console.WriteLine("Элемент найден");
else
    Console.WriteLine("Элемент не найден");
    



int sum = SumNegativeElements(arr);
Console.WriteLine($"сумма отрицательных элементов массива {sum}");
arr = ReverseSignElemebts(arr);
PrintArray(arr);
*/