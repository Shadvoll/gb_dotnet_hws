
using System.Globalization;
double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
{
    double rDouble = new Random().NextDouble();
    return rDouble * (upperBound - lowerBound) + lowerBound; ;
}
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
double[,] GenerateMatrix(int rows, int columns, double lowerBound, double upperBound)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = GetPseudoDoubleWithinRange(lowerBound, upperBound);
        }
    }
    return result;
}
void ShowMatrix(double[,] matrix, string text = null)
{
    CultureInfo ci = new CultureInfo("en-us");
    if (text != null)
    {
        Console.WriteLine(text);
    }
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    string output = null;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            output = matrix[i, j].ToString("F02", ci);
            Console.Write(output + "\t");
        }
        Console.WriteLine();
    }
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
double[,] matrix = GenerateMatrix(m, n, -100, 100);
ShowMatrix(matrix, "Сгенерированная матрица: ");