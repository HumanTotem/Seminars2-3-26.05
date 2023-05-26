void QuartersFind(int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine("Точка находится в первой плоскости");
        }
        else if (y < 0)
        {
            Console.WriteLine("Точка находится в четвертой плоскости");
        }
        else
        {
            Console.WriteLine("Точка на отрезке Y");
        }
    }
    else if (x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine("Точка находится во второй плоскости");
        }
        else if (y < 0)
        {
            Console.WriteLine("Точка находится в третей плоскости");
        }
        else
        {
            Console.WriteLine("Точка на отрезке Y");
        }
    }
    else
    {
        Console.WriteLine("Точка на отрезке X");
    }
}



Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
QuartersFind(x, y);