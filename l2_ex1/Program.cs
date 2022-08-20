int[] array = new int[10];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int index = collection.Length;
    while (index > 0)
    {
        index--;
        Console.Write($"({index}, {collection[index]}) ");
    }
}

int IndexOf(int[] collection, int find)
{   int index = 0;
    int count = collection.Length;
    while (index<count)
    {
        if (collection[index] == find)
        {
            return index;
            break;
        }
        index++;    
    }
    return -1;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int lf = new Random().Next(1,10);
Console.WriteLine($"Looking for position of {lf}");
Console.WriteLine(IndexOf(array,lf));