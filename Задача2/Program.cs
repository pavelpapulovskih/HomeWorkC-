//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

try
{
    Console.WriteLine("Введите два целлых числа");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2) Console.WriteLine("Первое число больше чем второе");
    else Console.WriteLine("Второе число больше чем первое");
}
catch
{
    Console.WriteLine("Введите числа");
}