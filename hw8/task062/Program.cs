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
void FillMatrixSpiral(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int k = 1;
    int count = 0;
    while (k < rows * cols - 1)
    {
        for (int j = count; j < cols - count; j++) // вправо
        {
            matrix[count, j] = k++;
            if (k >= rows * cols - 1) break;
        }
        for (int j = count + 1; j < rows - count; j++) //вниз
        {
            matrix[j, cols - 1 - count] = k++;
            if (k >= rows * cols - 1) break;
        }
        for (int j = cols - 2 - count; j >= count; j--) //влево
        {
            matrix[rows - count - 1, j] = k++;
            if (k >= rows * cols - 1) break;
        }
        for (int j = rows - 2 - count; j >= 1 + count; j--)//вверх
        {
            matrix[j, count] = k++;
            if (k >= rows * cols - 1) break;
        }
        count++;
    }
    if (rows * cols % 2 == 1)
    {
        matrix[rows / 2, cols / 2] = rows * cols;
    }
}

int rowsAndCols = 4;
int[,] matrix = new int[rowsAndCols, rowsAndCols];
FillMatrixSpiral(matrix);
ShowMatrix(matrix);