﻿Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(num1);
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(num2);
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(num1);
}
