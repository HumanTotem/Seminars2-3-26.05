Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int digit = 0;
if (number1 < 100 && number1 > -100)
{
    Console.WriteLine("Третьего числа нет");
}
else if (number1 > 100)
{
    while (number1 > 999)
    {
        number1 = number1/10;
    }
    digit = number1%10;
    Console.WriteLine($"{digit}");
}
else 
{
    while (number1 < -999)
    {
        number1 = number1/10;
        number1 = number1 * -1;
    }
    digit = number1%10;
    Console.WriteLine($"{digit}");
}