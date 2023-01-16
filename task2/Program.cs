// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа. Я выдам максимальное.");
int n = 3; // кол-во вводимых чисел
int i = 0; //счетчик на вводимые числа
Console.Write("Введите {0:D} число: ",i+1); 
int a = int.Parse(Console.ReadLine());
int max = a;
i++;
while (i < n){
    Console.Write("Введите {0:D} число: ",i+1);
    a = int.Parse(Console.ReadLine());
    if (a > max){
        max = a;
    }
    i++;
}
Console.WriteLine("Максимальное :" + max);
// задача сделана на любое кол-во входных данных. минимальное 1.