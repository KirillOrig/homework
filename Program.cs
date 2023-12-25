// Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток
// от деления.
//
// Примеры
// 
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3  => нет, 1

using System.Globalization;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b;
if (c == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine($"Нет, {c}");
}




