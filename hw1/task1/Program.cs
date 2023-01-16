// Задача: на вход 2 числа. Вывести макс и мин
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b){
    Console.WriteLine("Максимальное: " + a);
    Console.WriteLine("Минимальное: " + b);
}
else if (a < b) {
    Console.WriteLine("Максимальное: " + b);
    Console.WriteLine("Минимальное: " + a);
}
else{
    Console.WriteLine("Оба числа равны");
}

//Через библ-ку Math
// Console.WriteLine(Math.Max(a,b));
// Console.WriteLine(Math.Min(a,b));
