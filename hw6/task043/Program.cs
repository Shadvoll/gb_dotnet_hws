// * Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//         b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNum(string text)
{
    Console.Write(text);
    return double.Parse(Console.ReadLine());
}

Console.WriteLine("Программа, которая находит точку персечения двух прямых: ");
Console.WriteLine("1. y = k1 * x + b1");
Console.WriteLine("2. y = k2 * x + b2");
double b1 = GetNum("Введите b1 = ");
double k1 = GetNum("Введите k1 = ");
double b2 = GetNum("Введите b2 = ");
double k2 = GetNum("Введите k2 = ");
double x0 = (b2 - b1) / (k1 - k2);
double y0 = k1 * x0 + b1;
if (Math.Abs(k1) == Math.Abs(k2))
{
    Console.WriteLine("Прямые параллельны. Решений нет.");
}
else
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}. k2 = {k2} -> ({x0}; {y0})");
}