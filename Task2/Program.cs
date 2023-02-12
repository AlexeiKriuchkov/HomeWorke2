 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

long a;
Console.Write("Введите число: ");
a = Convert.ToUInt32(Console.ReadLine()); 

if(a % 1 == 0 & -100 < a & a < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (a <= -100)
{
    string str = Convert.ToString(a);
    System.Console.WriteLine("Третья цифра числа = {0}", str[3]);
}
else 
{
    string str = Convert.ToString(a);
    System.Console.WriteLine("Третья цифра числа = {0}", str[2]);
}

