// Задача: Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int ReadInt(string message)               // ввод количеста элементов массива
{
    System.Console.Write($"{message} > ");
    string newString = Console.ReadLine();
    if (int.TryParse(newString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}

bool NPositive(int n)                  // проверка положительности числа
{
    if (n <= 0)
    {
        System.Console.WriteLine($"Вы ввели число {n}, которое < или = 0");
        return false;
    }
    else
    {
        return true;
    }
}

string[] StringArray(int n)   // ввод массива пользователем
{
    string[] arrayS = new string[n];
    for (int j = 0; j < n; j++)
    {
        arrayS[j] = ReadString($"Введите {j + 1} элемент массива");
    }
    return arrayS;
}

string ReadString(string message)           // считывание строки
{
    System.Console.Write($"{message} > ");
    string newString = Console.ReadLine();
    return newString;
}

void PrintArray(string[] array)          // вывод массива
{
    foreach (string item in array)
    {
        System.Console.Write($"{item} ");
    }
}