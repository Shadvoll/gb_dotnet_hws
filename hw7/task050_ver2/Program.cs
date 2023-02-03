
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(lowerBound, upperBound + 1);
        }
    }
    return result;
}
void ShowMatrix(int[,] matrix, string text = null)
{
    if (text != null)
    {
        Console.WriteLine(text);
    }
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Tuple<bool, int> FindNumberInMatrix(int[,] matrix, int index)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    if (index > rows * columns - 1 || index < 0)
    {
        return new Tuple<bool, int>(false, 0);
    }
    int i = index / columns;
    int j = index % columns;

    return new Tuple<bool, int>(true, matrix[i, j]);
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, 0, 30);
ShowMatrix(matrix, "Сгенерированная матрица: ");
int index = GetNum("Введите глваный индекс числа для вывода: ");
Tuple<bool, int> answer = FindNumberInMatrix(matrix, index);
if (answer.Item1)
{
    Console.WriteLine($"Такое число есть: {answer.Item2}");
}
else
{
    Console.WriteLine("Такого числа нет.");
}