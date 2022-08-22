int GetDigitByNumber(int number, int position)
{   int divider = Convert.ToInt32(Math.Pow(10,position));
    int digit = number % divider*10 / divider;
    return digit;
}
Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a position of desired digit: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} digit of number {x} is {GetDigitByNumber(x,n)}");