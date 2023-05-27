int[] FillArrayWithRandomNumber(int size)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool NumberFound = false;
for (int i = 0; i < length; i++)
{
    if (number == array[i])
    {
        NumberFound = true;
        break;
    }  
}
if (NumberFound)
{
    System.Console.WriteLine($"Число {number} присутствует в массиве");
}
else
{
    System.Console.WriteLine($"Число {number} не присутствует в массиве");
}
