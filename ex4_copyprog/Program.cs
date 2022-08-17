// See https://aka.ms/new-console-template for more information
int xa = 45;
int xb = 90;
int xc = 1;
int ya = 1;
int yb = 30;
int yc = 30;
Console.Clear();

Console.SetCursorPosition(xa, ya);
Console.Write('+');
Console.SetCursorPosition(xb,yb);
Console.Write('+');
Console.SetCursorPosition(xc,yc);
Console.Write('+');
int x = xa, y = ya;
int count = 0;
while (count<300000)
{
    int choise = new Random().Next(0, 3);
    if (choise == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }
    if (choise == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }if (choise == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.Write('+');
    count ++;
} 
Console.WriteLine();