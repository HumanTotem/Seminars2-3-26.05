int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum+=i;
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
System.Console.WriteLine($"Сумма от 1 до {number} = {sum}");