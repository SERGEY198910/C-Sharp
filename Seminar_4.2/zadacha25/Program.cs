// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int a = ReadInt("введите число A: ");

int b = ReadInt("введите число B: ");
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}