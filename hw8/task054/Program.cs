
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
int[] BubbleSort(int[] array)
{
    int[] resultArray = (int[])array.Clone();
    for (int i = 0; i < resultArray.Length; i++)
    {
        for (int j = i + 1; j < resultArray.Length; j++)
        {
            if (resultArray[i] < resultArray[j])
            {
                (resultArray[i], resultArray[j]) = (resultArray[j], resultArray[i]);
            }
        }
    }
    return resultArray;
}
int[,] SortMatrixRows(int[,] matrix)
{
    int[,] resultMatrix = (int[,])matrix.Clone();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        int[] sortedRow = BubbleSort(Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[i, x])
                .ToArray());
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = sortedRow[j];
        }
    }

    return resultMatrix;
}
int n = GetNum("Количество строк: ");
int m = GetNum("Количество столбцов: ");
int[,] matrix = CreateMatrix(n, m, 0, 10);

ShowMatrix(matrix, "Оригинальная матрица");
int[,] resMatrix = SortMatrixRows(matrix);
ShowMatrix(resMatrix, "Результат: ");
