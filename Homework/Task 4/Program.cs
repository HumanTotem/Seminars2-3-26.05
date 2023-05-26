System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(number);
bool Result = true;
for (int index = 0; index < numbers.Length/2; index++)
{
    if(numbers[index] != numbers[numbers.Length - index - 1])
    {
        Result = false;
        break;
    }
}
if (Result)
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("Это не палиндром");
}