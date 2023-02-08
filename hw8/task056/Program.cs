
int[,] CreateMatrix(int rows, int cols, int lowerBound, int upperBound)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(lowerBound, upperBound + 1);
        }
    }
    return matrix;
}
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
void ShowMatrix(int[,] matrix, string text = null)
{
    if (text != null)
    {
        Console.WriteLine(text);
    }
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int[] SumsOfRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[] sums = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        sums[i] = Enumerable.Range(0, cols).Select(x => matrix[i, x]).Sum();
    }
    return sums;
}
int FindMinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}
int n = GetNum("Количество строк: ");
int m = GetNum("Количество столбцов: ");
int[,] matrix = CreateMatrix(n, m, 0, 10);
ShowMatrix(matrix, "Оригинальная матрица");
int[] sums = SumsOfRows(matrix);
Console.WriteLine($"Строка с минимальной суммой: {FindMinIndex(sums)}");
