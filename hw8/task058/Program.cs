
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
int[] ProductCorrespondArray(int[] arrayOne, int[] arrayTwo)
{
    int[] result = new int[arrayOne.Length];
    for (int i = 0; i < arrayOne.Length; i++)
    {
        result[i] = arrayOne[i] * arrayTwo[i];
    }
    return result;
}
int[] GetRow(int[,] matrix, int row)
{
    return Enumerable.Range(0, matrix.GetLength(1)).Select(x => matrix[row, x]).ToArray();
}
int[] GetCol(int[,] matrix, int col)
{
    return Enumerable.Range(0, matrix.GetLength(0)).Select(x => matrix[x, col]).ToArray();
}
int[,] ProductMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int resultRows = matrixOne.GetLength(0);
    int resultCols = matrixTwo.GetLength(1);
    int[,] resultMatrix = new int[resultRows, resultCols];
    for (int i = 0; i < resultRows; i++)
    {
        for (int j = 0; j < resultCols; j++)
        {
            resultMatrix[i, j] = ProductCorrespondArray(GetRow(matrixOne, i), GetCol(matrixTwo, j)).Sum();
        }
    }
    return resultMatrix;
}
int rowsOne = GetNum("Количество строк первой: ");
int rowsAndCols = GetNum("Количество столбцов первой и строк второй: ");
int colsTwo = GetNum("Количество столбцов второй матрицы: ");
int[,] matrixOne = CreateMatrix(rowsOne, rowsAndCols, 0, 10);
int[,] matrixTwo = CreateMatrix(rowsAndCols, colsTwo, 0, 10);
ShowMatrix(matrixOne, "Первая матрица: ");
ShowMatrix(matrixTwo, "Вторая матрица: ");
int[,] resultMatrix = ProductMatrix(matrixOne, matrixTwo);
ShowMatrix(resultMatrix, "Результат произвидения матриц: ");