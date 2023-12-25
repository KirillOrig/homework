// Напишите программу, которая выводит третью с конца и начала цифру
// заданного числа или сообщает, что третьей цифры нет.
// 
// 456 => 4
// 7812 => 8 
// 91 => Третьей цифры нет

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num_len = Convert.ToString(n).Length;
//Console.WriteLine(num_len);
int b;
int a = n / 100;
if (a < 1){
    Console.WriteLine("Третьей цифры нет.");
}
else{
    a = a % 10;
    Console.WriteLine($"{n} => {a}");
    b = n / Convert.ToInt32(Math.Pow(10,(num_len - 3)));
    b = b % 10;
    Console.WriteLine($"{n} => {b}");
}



