int[] FillArrayWithRandomNumber(int size)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных чисел в массиве: {count}");
