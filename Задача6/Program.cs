﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

try
{
    Console.WriteLine("Введите целое число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num%2 == 0) Console.WriteLine ("Это число четное");
    else Console.WriteLine("Это число не четное");
}
catch
{
    Console.WriteLine("Введите число");
}
