// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double number (string i)
{
    System.Console.Write($"Введите значение {i} > ");
    return double.Parse(Console.ReadLine());
}

double m = number ("m");
double n = number ("n");
akerman(m, n);
System.Console.WriteLine(akerman(m, n));

double akerman(double m, double n)
{

    if (m>0 && n>0) return akerman(m-1,akerman(m,n-1));
    else if (m>0 && n==0) return akerman(m-1,1);
    else if (m==0) n=n+1; return n;
    
}