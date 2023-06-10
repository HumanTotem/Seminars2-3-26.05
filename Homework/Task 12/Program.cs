void massive(int number, int[] Array)
{
    for (int i = 0; i < number; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} элемент");
        Array[i] = Convert.ToInt32(System.Console.ReadLine());
    }
}

int positive(int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
        {
            sum++;
        }
        i++;
    }
    return sum;
}
System.Console.WriteLine("Введите размер массива");
int number = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [number];
massive(number, Array);
System.Console.WriteLine($"В массиве {positive(Array)} чисел больше 0");