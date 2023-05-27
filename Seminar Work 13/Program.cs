int Multiply(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int mult = Multiply(number);
System.Console.WriteLine($"Сумма от 1 до {number} = {mult}");