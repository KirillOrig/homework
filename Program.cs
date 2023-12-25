// Напишите программу, которая принимает на вход трехзначное число
// и удаляет вторую цифру этого числа.
// 
// Примеры
// 
// a = 256 => 26
// a = 891 => 81

int num = new Random().Next(100, 1000);

int num1 = num / 100;
int num2 = num % 10;

Console.WriteLine(num);
Console.WriteLine(num1 + "" + num2);
Console.WriteLine(num1 * 10 + num2);

Console.WriteLine($"{num} => {num1 + "" + num2}");



