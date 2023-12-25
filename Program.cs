// Напишите программу, которая принимает на вход трехзначное число
// и удаляет вторую цифру этого числа.
// 
// Примеры
// 
// a = 256 => 26
// a = 891 => 81

int num = new Random().Next(100, 1000);

string num1 = Convert.ToString(num / 100);
string num2 = Convert.ToString(num % 10);

Console.WriteLine(num);
Console.WriteLine(num1 + num2);
//Console.WriteLine(num1 * 10 + num2);

//Console.WriteLine($"{num} => {num1 + "" + num2}");



