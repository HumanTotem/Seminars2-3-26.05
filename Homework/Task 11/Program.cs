double[] FillArrayWithRandomNumber(int size)
{
    double[] array = new double [size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
double result = Math.Round(array[length - 1] - array[0], 1);
System.Console.WriteLine($"Разница между последним и первым числами массива равна {result}");