// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
string GetString(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}
int[] ReadArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetNum($"Введите {i + 1} элемент массива: ");
    }
    return array;
}
void PrintArray(int[] array)
{
    int size = array.Length;
    if (size <= 0)
    {
        Console.WriteLine("[]");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}]");  // ^1 === size -1
}

int size = GetNum("Введите размер массива: ");
string userAnswer = null;
userAnswer = GetString("Меню\n1. Сгенерировать массив\n2. Ввести массив\nОтвет (1,2) : ");
if (userAnswer == "1")
{
    Console.WriteLine("Генерирую.");
    int[] array = CreateRandomArray(size);
    Console.Write("Ваш массив готов: ");
    PrintArray(array);
}
else if (userAnswer == "2")
{
    Console.WriteLine("Ввод. ");
    int[] array = ReadArray(size);
    Console.Write("Ваш массив готов: ");
    PrintArray(array);
}
else
{
    Console.WriteLine("Неверный ввод. Требется ввести цифру '1' или '2'. ");
}

