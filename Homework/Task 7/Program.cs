System.Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0)
{
    number2 = number2 * -1;
}

double multiply = Math.Pow(number1, number2);
System.Console.WriteLine($"Число {number1} в натуральной степени {number2} равна {multiply}");
