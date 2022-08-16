// See https://aka.ms/new-console-template for more information
Console.Write("Enter number one");
Int32 numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number two ");
Int32 numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numA + numB);
Int32 a = new Random().Next(numA, numB);
Int32 b = new Random().Next(numA, numB);
Console.Write(a);
Console.Write('+');
Console.Write(b);
Console.Write('=');
Console.Write(a+b);
