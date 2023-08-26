int dayNumber = Prompt("Введите число от 1 до 7: ");
Console.WriteLine(Holiday(dayNumber));


// ФУНКЦИИ------------------------------------------------------------------------------------------------------


int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


string Holiday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}