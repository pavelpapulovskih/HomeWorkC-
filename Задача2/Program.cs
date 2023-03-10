try
{
    Console.WriteLine("Введите два числа");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2) Console.WriteLine("Первое число больше чем второе");
    else Console.WriteLine("Второе число больше чем первое");
}
catch
{
    Console.WriteLine("Введите числа");
}