 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine(" ");

Console.Write("Введите число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    if (number > 99)
    {
        int Digit = 0;
        Digit = number;

        for (int i = 1; i >= 2; i++)
        {
            Digit = Digit / 10;
        }
    
        Digit = Digit % 10;
        Console.WriteLine("Третьей цифрой числа " + number + " является " + Digit);
    }
    else Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine(" ");
