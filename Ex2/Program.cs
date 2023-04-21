// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double number (string i)
{
    System.Console.Write($"Введите значение {i} > ");
    return double.Parse(Console.ReadLine());
}

double max = number ("max");
double min = number ("min");
sumNumber(max, min);
System.Console.WriteLine(sumNumber(max, min));

double sumNumber(double max, double min)
{
    if (max == min) 
    {
        return min;
    }
    else 
    {
        return sumNumber(max-1,min)+max;
    }
  
}