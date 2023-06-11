void fillmatrix(int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}
void printmatrix(int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}" + "\t");
        }
        System.Console.WriteLine();
    }
}
int Sum(int[,] matrix)
{
    int sum = 0;
    int result = 0;
    int count = 1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, 0];
            result = sum/count;
            System.Console.Write($"{result}" + "\t");
            count++;
    }
    return sum;
}


System.Console.Write("Введите количество строк массива: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int stolbcy = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[stroka, stolbcy];
fillmatrix(matrix);
printmatrix(matrix);
Sum(matrix);