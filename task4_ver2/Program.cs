// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N и я выведу все четные числа от 1 до N: ");
int n = int.Parse(Console.ReadLine());
int i = 2;
while (i <= n)
{
    Console.Write(i + " ");
    i += 2;
}
if (n < 2)
{
    Console.WriteLine("Пустое множество");
}