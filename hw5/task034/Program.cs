// * Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int[] CreateRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(left, right);
    }
    return array;
}
int CountEvens(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int size = GetNum("Введите размер массива: ");
int[] array = CreateRandomArray(size, 100, 999 + 1);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine($"Количество четных чисел {CountEvens(array)}");
