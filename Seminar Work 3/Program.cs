Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int digit = number1%number2;
if (digit == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не кратно числу {number1}. Остаток: {digit}");
}