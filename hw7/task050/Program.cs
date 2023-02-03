
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
bool FindNumberInMatrix(int[,] matrix, int number)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] == number)
            {
                return true;
            }
        }
    }
    return false;
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, -10, 10);
ShowMatrix(matrix, "Сгенерированная матрица: ");
int number = GetNum("Введите число для поиска: ");
if (FindNumberInMatrix(matrix, number))
{
    Console.WriteLine("Такое число есть.");
}
else
{
    Console.WriteLine("Такого числа нет.");
}