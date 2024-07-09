// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void Main()
{
    int number = ReadInt("Введите число: ");
    PrintNumber(number);
}

void PrintNumber(int N)
{
    if(N < 1) return;
    System.Console.Write(N + " ");
    PrintNumber(N - 1);    
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();