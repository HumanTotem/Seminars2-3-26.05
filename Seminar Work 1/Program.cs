int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число: {number}");
int digit1 = number/10;
int digit2 = number%10;
if (digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} больше");
}
else
{
    Console.WriteLine($"Цифра {digit2} больше");
}