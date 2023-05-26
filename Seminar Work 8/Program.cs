// Console.WriteLine("Введите номер четверти: ");
// int quater = Convert.ToInt32(Console.ReadLine());
// if (quater == 1)
// {
//     Console.WriteLine("Диапазон возможных чисел этой четверти: X > 0, Y > 0");
// }
// else if (quater == 2)
// {
//     Console.WriteLine("Диапазон возможных чисел этой четверти: X < 0, Y > 0");
// }
// else if (quater == 3)
// {
//     Console.WriteLine("Диапазон возможных чисел этой четверти: X < 0, Y < 0");
// }
// else if (quater == 4)
// {
//     Console.WriteLine("Диапазон возможных чисел этой четверти: X > 0, Y < 0");
// }
// else
// {
//     Console.WriteLine("Не является частью системы координат");
// }
string FindDiapason(string[] quaters, int quater)
{
string result = quaters[quater - 1];
return result;
}

string[] quaters = {
"x > 0 y > 0",
"x < 0 y > 0",
"x < 0 y < 0",
"x > 0 y < 0"
};
Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater >= 1 && quater <= 4)
{
Console.WriteLine(FindDiapason(quaters, quater));
}
else
{
System.Console.WriteLine("Неправльный номер четверти");
}