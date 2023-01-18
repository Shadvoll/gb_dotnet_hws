// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Функция выводящая все цифры числа в виде списка. 
List<int> GetAllDigitsAsList(int number)
{
    List<int> result = new List<int>();
    while (number > 0)
    {
        result.Add(number % 10);
        number /= 10;
    }
    result.Reverse();
    return result;
}
Console.WriteLine("Программа, которая выводит третью цифру введенного числа, если оно есть, иначе сообщает, что её нет.");
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());
List<int> digits = GetAllDigitsAsList(number);
if (digits.Count >= 3)
{
    Console.WriteLine($"Третья цифра числа {number} является {digits[2]}");
}
else
{
    Console.WriteLine($"У числа {number} нет третьей цифры, так как всего цифр {digits.Count}.");
}