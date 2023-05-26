Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int digit1 = number/10;
    int digit2 = digit1%10;
    Console.WriteLine(digit2);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}
