﻿Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 == number1*number1)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Ни одно число не является квадратом другого");
}