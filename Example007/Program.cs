Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xA = 30, yA = 1,
    xB = 1, yB = 20,
    xC = 60, yC = 20;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("*");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("*");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("*");

int x = xA, y = yB;

int count = 10;

while (count < 10000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x+xA)/2;
        y = (y+yA)/2;
    }
    else if (what == 1)
    {
        x = (x+xB)/2;
        y = (y+yB)/2;
    }
    else if (what == 2)
    {
        x = (x+xC)/2;
        y = (y+yC)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}