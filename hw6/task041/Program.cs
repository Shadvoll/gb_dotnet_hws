// * Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//         0, 7, 8, -2, -2 -> 2
//         1, -7, 567, 89, 223-> 3

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int amount = GetNum("Введите число количества чисел: ");
int count = 0;
for (int i = 0; i < amount; i++)
{
    if (GetNum($"Введите {i} число: ") > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {count}");