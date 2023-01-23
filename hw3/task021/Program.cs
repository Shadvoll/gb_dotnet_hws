// * Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//     A (3,6,8); B (2,1,-7), -> 15.84

//     A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
double CalcLength(int[] coorsA, int[] coorsB)
{
    double result = 0;
    for (int i = 0; i < 3; i++)
    {
        result += Math.Pow(coorsA[i] - coorsB[i], 2);
    }
    return Math.Sqrt(result);
}
int[] coordinatesA = new int[3];
int[] coordinatesB = new int[3];

coordinatesA[0] = GetNum("Insert x coor for point A: ");
coordinatesA[1] = GetNum("Insert y coor for point A: ");
coordinatesA[2] = GetNum("Insert z coor for point A: ");

coordinatesB[0] = GetNum("Insert x coor for point B: ");
coordinatesB[1] = GetNum("Insert y coor for point B: ");
coordinatesB[2] = GetNum("Insert z coor for point B: ");

Console.WriteLine($"The distance between 2 points : {Math.Round(CalcLength(coordinatesA, coordinatesB), 2)}");