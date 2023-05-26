// System.Console.WriteLine(Math.Pow(12, 2));
// System.Console.WriteLine(Math.Sqrt(144));
// double N = 12.596049509456;
// System.Console.WriteLine(Math.Round(N, 2));

double Length(double X1, double X2, double Y1, double Y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)), 2);   
}

Console.Write("Введите координаты точки 1: X1 = ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 1: Y1 = ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2: X2 = ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2: Y2 = ");
double Y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Length(X1, X2, Y1, Y2));