System.Console.WriteLine("Введите количество первых чисел Фиббоначи: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp1 = 1;
int temp2 = 1;
int fibbo = 0;
System.Console.WriteLine("1");
System.Console.WriteLine("1");
for (int i = 3; i <= n; i++)
{
    fibbo = temp1 + temp2;
    temp2 = temp1;
    temp1 = fibbo;
    System.Console.WriteLine(fibbo);
}