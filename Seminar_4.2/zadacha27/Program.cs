// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int i = ReadInt("введите число: ");
int sum = 0;

while (i > 0)
{
int number = i % 10;
i = i / 10;
sum = sum + number;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}