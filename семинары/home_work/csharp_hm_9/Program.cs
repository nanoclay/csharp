// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void PrintNumber(int num)
{
    if (num == 1)
        Console.WriteLine(num);

    else
    {
        Console.Write(num + ", ");
        PrintNumber(num - 1);
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int PrintNumber(int m, int n, int sum)
{
    if (m > n)
        return sum;

    else
    {
        sum = sum + m ;
        m++;
        return PrintNumber(m, n, sum);
    }
}

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int mum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(num, mum, 0));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int mum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(num, mum));