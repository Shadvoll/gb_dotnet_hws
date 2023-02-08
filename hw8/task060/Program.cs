int[,,] CreateMatrix(int dimensionOne,
                     int dimensionTwo,
                     int dimensionThree,
                     int lowerBound,
                     int upperBound)
{
    int[,,] matrix = new int[dimensionOne, dimensionTwo, dimensionThree];
    int[] choice = GenerateChoiceRange((dimensionOne+1) * (dimensionTwo+1) * (dimensionThree +1), lowerBound, upperBound);
    for (int i = 0; i < dimensionOne; i++)
    {
        for (int j = 0; j < dimensionTwo; j++)
        {
            for (int k = 0; k < dimensionThree; k++)
            {
                Console.WriteLine($"{i} {j} {k} - {i + dimensionTwo * (j + dimensionThree * k)}");
                matrix[i, j, k] = choice[i + dimensionTwo * (j + dimensionThree * k)];
            }
        }
    }
    return matrix;
}
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int[] GenerateChoiceRange(int size, int lowerBound, int upperBound)
{
    int[] result = new int[size];
    int i = 0;
    int rndNumber = new Random().Next(lowerBound, upperBound);
    while (i < size)
    {
        if (!result.Contains(rndNumber))
        {
            result[i++] = rndNumber;
        }
        rndNumber = new Random().Next(lowerBound, upperBound);
    }
    return result;
}
void ShowThreeDimMatrix(int[,,] matrix)
{
    int dimensionOne = matrix.GetLength(0);
    int dimensionTwo = matrix.GetLength(1);
    int dimensionThree = matrix.GetLength(2);
    for (int i = 0; i < dimensionOne; i++)
    {
        for (int j = 0; j < dimensionTwo; j++)
        {
            for (int k = 0; k < dimensionThree; k++)
            {
                Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k})");
            }
        }
    }
}
int dimensionOne = GetNum("Первая размерность: ");
int dimensionTwo = GetNum("Вторая размерность: ");
int dimensionThree = GetNum("Третья размерность: ");
int[,,] matrix = CreateMatrix(dimensionOne, dimensionTwo, dimensionThree, 10, 100);
ShowThreeDimMatrix(matrix);