double Length(double X1, double X2, double Y1, double Y2, double Z1, double Z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);   
}

Console.Write("Введите координаты точки 1: X1 = ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 1: Y1 = ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 1: Z1 = ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2: X2 = ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2: Y2 = ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2: Z1 = ");
double Z2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Length(X1, X2, Y1, Y2, Z1, Z2));