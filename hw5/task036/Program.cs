// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int[] CreateRandomArray(int size, int lowerBound, int upperBound)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lowerBound, upperBound);
    }
    return array;
}
int CalcSumEvenIndices(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = GetNum("Введите размер массива: ");
int[] array = CreateRandomArray(size, 0, 10);
Console.WriteLine("Сгенерированный массив: ");
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма элементов на нечетных позициях: {CalcSumEvenIndices(array)}");