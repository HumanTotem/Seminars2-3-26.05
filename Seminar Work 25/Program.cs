void fillmatrix(int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
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
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            sum = sum + matrix[i, j];
        }
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
System.Console.WriteLine(Sum(matrix));