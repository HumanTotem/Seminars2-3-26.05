void fillmatrix(int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(4, 10);
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
               if (i % 2 == 0 && j % 2 == 0)
                {
                    matrix[i, j] = matrix[i, j] * matrix[i, j];
                }
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