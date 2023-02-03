
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
int[] CalcSumsOfCols(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] sums = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sums[j] += matrix[i, j];
        }
    }
    return sums;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, 0, 10);
ShowMatrix(matrix, "Сгенерированная матрица: ");
int[] sums = CalcSumsOfCols(matrix);
Console.WriteLine("Суммы столбцов: ");
ShowArray(sums);
