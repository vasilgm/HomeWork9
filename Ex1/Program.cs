// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double number (string i)
{
    System.Console.Write($"Введите значение {i} > ");
    return double.Parse(Console.ReadLine());
}

double max = number ("max");
double min = number ("min");
outputNumber(max, min);

void outputNumber(double max, double min)
{
    if (max > 0 ) 
    {
        System.Console.WriteLine(max);
        outputNumber(max-1,min);
    }
}