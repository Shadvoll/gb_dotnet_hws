# Д.з. по dotNet C# для GB
## Полезности. Примеры кода. Для себя.
* Словари

        Dictionary<int, string> weekDays = new Dictionary<int, string>(){
        {1,"Monday"},
        {2,"Tuesday"},
        {3,"Wednesday"},
        {4,"Thursday"},
        {5,"Friday"},
        {6,"Saturday"},
        {7,"Sunday"}
        };
        Console.Write(weekDays[1]);

* Списки

        // Функция выводящая все цифры числа в виде списка. 
        List<int> GetAllDigitsAsList(int number)
        {
            List<int> result = new List<int>();
            while (number > 0)
            {
                result.Add(number % 10);
                number /= 10;
            }
            result.Reverse();
            return result;
        }
    **List.Count** - кол-во элементов в списке