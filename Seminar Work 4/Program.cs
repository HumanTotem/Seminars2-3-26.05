Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int digit1 = number1%7;
int digit2 = number1%23;
if (digit1 == 0 && digit2 == 0)
{
    Console.WriteLine($"Число {number1} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number1} не кратно 7 и 23");
}