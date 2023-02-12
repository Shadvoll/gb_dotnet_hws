int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void RecursiveInverseOut(int number){
    Console.Write($"{number} ");
    if (number == 1){
        return;
    }
    RecursiveInverseOut(number - 1);
}

int number = GetNum("Введите число N: ");
RecursiveInverseOut(number);
