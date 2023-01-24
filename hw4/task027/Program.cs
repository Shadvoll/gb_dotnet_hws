// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int SumDigits(int number)
{
    if (number > 0)
    {
        return number % 10 + SumDigits(number / 10);
    }
    return 0;
}

int number = GetNum("Введите число. Я посчитаю сумму цифр: ");
Console.WriteLine($"Сумма цифр в числе {number} : {SumDigits(Math.Abs(number))}");

