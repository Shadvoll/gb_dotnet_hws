int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int CalcSum(int from, int to)
{
    if (from == to)
    {
        return to;
    }
    return from + CalcSum(from + 1, to);
}


int N = GetNum("Введитие число N: ");
int M = GetNum("Введитие число M: ");

Console.WriteLine($"Сумма от {M} до {N}: {CalcSum(N, M)}");