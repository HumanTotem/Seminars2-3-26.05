System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if (int.TryParse(num, out int number))
{
System.Console.WriteLine(num.Length);
}
else
{
System.Console.WriteLine("Ошибка: нужно ввести число");
}