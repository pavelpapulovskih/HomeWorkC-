// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
try
{
    Console.WriteLine("Введите целлое число");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
            System.Console.Write(i + " ");
    }
}
catch
{
    Console.WriteLine("Введите числа");
}