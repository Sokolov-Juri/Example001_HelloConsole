Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int maxcoord = 20;

int xa = 1,  ya = 1, 
    xb = 1,  yb = maxcoord,
    xc = maxcoord, yc = maxcoord;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("O");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("O");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("O");

int x = xa, y = xb;
int count = 0;

while(count < 100000)
{
    int what = new Random().Next(0, 3);

    if (what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if (what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

    if (what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("O");
    count += 1;

}
Console.SetCursorPosition(maxcoord + 1, maxcoord + 1);