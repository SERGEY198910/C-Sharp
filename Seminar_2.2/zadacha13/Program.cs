int number = Prompt("Введите число: ");
int count = number.ToString().Length;
Console.Write(ThirdNum(number, count));


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int ThirdNum(int a, int b)
{
int result = -1;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, минус тебе ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}