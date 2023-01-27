// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
double[] CreateRandomArray(int size, int lowerBound, int upperBound)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetPseudoDoubleWithinRange(lowerBound, upperBound);
    }
    return array;
}
double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
{
    double rDouble = new Random().NextDouble();
    return rDouble * (upperBound - lowerBound) + lowerBound; ;
}
void PrintDoubleArray(double[] array, int precision = -1)
{
    if (precision >= 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(Math.Round(array[i], precision) + " ");
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        max = Math.Max(max, array[i]);
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        min = Math.Min(min, array[i]);
    }
    return min;
}

int size = GetNum("Введите размер массива: ");
double[] array = CreateRandomArray(size, 0, 10);
Console.WriteLine("Сгенерированный массив: ");
PrintDoubleArray(array, 2);
double max = FindMax(array);
double min = FindMin(array);
Console.WriteLine($"Максимум: {max}\nМинимум: {min}");
Console.WriteLine($"Разница между максимум и минимум: {max - min}");