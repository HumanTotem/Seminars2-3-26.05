void fillmatrix(int[,] matrix)
{
    double[,] matrica = new double[matrix];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble()  * 100, 1);
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


System.Console.Write("Введите количество строк массива: ");
double stroka = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
double stolbcy = Convert.ToDouble(Console.ReadLine());
double[,] matrix = new double[stroka, stolbcy];

fillmatrix(matrix);
printmatrix(matrix);