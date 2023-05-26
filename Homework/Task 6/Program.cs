Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

for (int itteration = 1; itteration <= number; itteration++)
{
    System.Console.Write(Math.Pow(itteration, 3) + " ");
}