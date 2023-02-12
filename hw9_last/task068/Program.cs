int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int Ackerman(int n, int m){
    if (n == 0){
        return m + 1;
    }
    if ( m == 0){
        return Ackerman(n-1,1);
    }
    return Ackerman(n-1,Ackerman(n,m-1));
}
int N = GetNum("Введитие число M: ");
int M = GetNum("Введитие число N: ");
Console.WriteLine($"Ackermann Function({N},{M}) = {Ackerman(N,M)}");