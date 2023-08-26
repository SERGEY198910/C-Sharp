int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SecondNum(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
int number = Prompt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(SecondNum(number));
}
