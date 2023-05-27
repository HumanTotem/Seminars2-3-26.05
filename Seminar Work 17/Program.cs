int[] FillArrayWithRandomNumber(int size)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 1000);
    }
    return array;
}
int length = 123;
int[] array = FillArrayWithRandomNumber(length);
for (int i = 0; i < length; i++)
{
    if (array[i] > 10 && array[i] < 99)
    {
        System.Console.Write(array[i] + ", ");
    }
}