// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
string GetString(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
bool CheckInput(string input)
{
    if (input.Length == 5)
    {
        return int.TryParse(input, out _);;
    }
    return false;
}
bool IsPalindrome(string input)
{
    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[^(i + 1)])
        {
            return false;
        }
    }
    return true;
}

string inputString = GetString("Insert a 5 digit number: ");
if ( CheckInput(inputString) )
{
    
    if ( IsPalindrome(inputString) ){
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("Invalid input");
}
