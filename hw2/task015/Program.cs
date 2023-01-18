// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Программа, которая по номеру дня недели выводит выходной или нет.");
Console.Write("Введите номер дня недели (1-7): ");
int weekDayNumber = int.Parse(Console.ReadLine());
if (weekDayNumber>0 && weekDayNumber < 8)
{
    if (weekDayNumber == 6 || weekDayNumber == 7){
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else{
    Console.WriteLine("Неверный ввод. Номер должен быть от 1 до 7");
}