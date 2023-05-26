Console.WriteLine("Введите код дня недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 6)
{
    Console.WriteLine("Это будний день");
}
else if (number1 > 5 && number1 < 8)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это не код дня недели");    
}