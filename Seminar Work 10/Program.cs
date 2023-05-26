Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());
//int itteration = 1;
// while (itteration <= number)
// {
//     System.Console.Write(Math.Pow(itteration, 2));
//     itteration++; 
// }
for (int itteration = 1; itteration <= number; itteration++)
{
    System.Console.Write(Math.Pow(itteration, 2) + " ");
}