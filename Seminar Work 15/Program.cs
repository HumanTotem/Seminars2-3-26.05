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

int[] ReplaceWithNegative(int size)
{
    for (int j = 0; j < array.Length; j++)
    {
       array[j] *= -1;
    }
    return array;
}

int[] array1 = ReplaceWithNegative(length);
System.Console.WriteLine(string.Join(", ", array));