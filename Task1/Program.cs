 // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine();

Console.Write("Введите число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    int Digit=0;
    Digit = number;
    Digit = Digit/10;
    Digit = Digit%10;
    Console.WriteLine("Второй цифрой числа " + number + " является " + Digit);

}

Console.WriteLine();
