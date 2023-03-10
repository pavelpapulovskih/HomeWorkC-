// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет.
// Через строку решать нельзя.
try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(num);

    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int num1 = num % 10;
        Console.WriteLine(num1);
    }
    else
    {
        Console.Write("Введенное число меньше 100");
    }
}
catch
{
    Console.WriteLine("Введите число");
}