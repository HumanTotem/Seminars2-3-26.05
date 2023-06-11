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
};
System.Console.Write("Введите количество строк массива: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int stolbcy = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[stroka, stolbcy];
fillmatrix(matrix);
printmatrix(matrix);
System.Console.Write("Введите индекс строки: ");
int indstroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца: ");
int indstolbcy = Convert.ToInt32(Console.ReadLine());
if (indstroka <= stroka && indstolbcy < stolbcy)
{
    System.Console.WriteLine($"Число с введенным индексом: {matrix[indstroka, indstolbcy]}");
}
else
{
    System.Console.WriteLine("Такого индекса не существует");
}