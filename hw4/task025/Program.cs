// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int MyPower(int number, int power)
{
    if (power == 0)
    {
        return 1;
    }
    return MyPower(number, power - 1) * number;
}

int number = GetNum("Введите основание: ");
int power = GetNum("Введите степень числа: ");
Console.WriteLine($"Результат возведения в степень: {MyPower(number, power)}");