void GetBinaryView(int number)
{
    if (number == 0)
    {
        return;
    }
    GetBinaryView(number / 2);
    Console.Write(number % 2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);