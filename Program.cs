using System;

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write($"Введите первую координату точки. num1 = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите вторую координату точки. num2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 != 0 && num2 != 0)
{
    if (num1 < 0 && num2 < 0)
    {
        Console.WriteLine($"Точка находится в III четверти");
    }
    if (num1 > 0 && num2 > 0)
    {
        Console.WriteLine($"Точка находится в I четверти");
    }
    if (num1 < 0 && num2 > 0)
    {
        Console.WriteLine($"Точка находится в II четверти");
    }
    if (num1 > 0 && num2 < 0)
    {
        Console.WriteLine($"Точка находится в IV четверти");
    }
}


