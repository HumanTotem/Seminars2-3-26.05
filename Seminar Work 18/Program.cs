// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numbers = Convert.ToString(number);
// bool Result = true;
// for (int index = 0; index < numbers.Length/2; index++)
// {
//     if(numbers[index] != numbers[numbers.Length - index - 1])
//     {
//         Result = false;
//         break;
//     }
// }
// if (Result)
// {
//     System.Console.WriteLine("Это палиндром");
// }
// else
// {
//     System.Console.WriteLine("Это не палиндром");
// }


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
int newLength = array.Length/2 + array.Length%2;
int[] newarray = new int [newLength];
for (int index = 0; index < array.Length/2; index++)
{
    newarray[index] = array[index] * array[array.Length - index - 1];
}
if (array.Length %2 == 1)
{
    newarray[newarray.Length -1] = array[array.Length/2];
}
System.Console.WriteLine(string.Join(", ", newarray));