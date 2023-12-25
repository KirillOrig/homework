// Напишите программу, которая выводит третью с конца и начала цифру
// заданного числа или сообщает, что третьей цифры нет.
// 
// 456 => 4
// 7812 => 8 
// 91 => Третьей цифры нет

using System.Globalization;

Console.WriteLine("Введите число:");
string num = Console.ReadLine();
int num_len = num.Length;
//Console.WriteLine(num_len);

if (num_len < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string num1 = Convert.ToString(num[2]);
    Console.WriteLine($"Третье число с начала {num1}");
    string num2 = Convert.ToString(num[num_len-3]);
    Console.WriteLine($"Третье число с конца {num2}");
}



