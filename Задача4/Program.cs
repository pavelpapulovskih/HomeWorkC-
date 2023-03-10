//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
try
{
    Console.WriteLine("Введите три целлых числа");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;
    if (num2 > max)
    {
        max = num2;
    }
    if (num3 > max)
    {
        max = num3;
    }
    Console.Write("максимальное значение=");
    Console.WriteLine(max);
}
catch
{
    Console.WriteLine("Введите числа");
}
