void fillmatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
}
void printmatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}" + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int stolbcy = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[stroka, stolbcy];

fillmatrix(matrix);
printmatrix(matrix);