// Напишите программу, которая выводит третью с конца и начала цифру
// заданного числа или сообщает, что третьей цифры нет.
// 
// 456 => 4
// 7812 => 8 
// 91 => Третьей цифры нет

string s = Console.ReadLine();
if (s.Length < 3) 
{
    Console.WriteLine("No third number.");
    return;
}
int i = Convert.ToInt32(s);
int thirdFirst = i / (int)Math.Pow(10, s.Length - 3);
thirdFirst = thirdFirst - thirdFirst / 10 * 10;
int thirdLast = i / 100;
thirdLast = thirdLast - thirdLast / 10 * 10;
Console.WriteLine("For number " + i + " first third number is " 
                + thirdFirst + " last third is " + thirdLast);



