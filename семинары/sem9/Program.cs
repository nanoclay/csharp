// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

/*
void PrintNumber(int num, int n = 1)
{
    if (num == n)
        Console.WriteLine(num);

    else
    {
        Console.Write(n + ", ");
        PrintNumber(num, n + 1);
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number, 1);
*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

/*
void PrintNumber(int m, int n)
{
    if (m == n)
        Console.WriteLine(m);

    else
    {
        Console.Write(m + ", ");
        PrintNumber(m + 1, n);
    }
}

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int mum = Convert.ToInt32(Console.ReadLine());

PrintNumber(num, mum);
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

/*
int PowerAB(int a, int b, int sum)
{
    if (b < 1)
       return sum;
    else
    {
        sum = sum * a;
        b--;
        return PowerAB(a, b, sum);
    }
}

Console.Write("Введите первое число: ");
int aNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int bNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerAB(aNum, bNum, 1));
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits(int number, int start)
{

    if(number == 0)
        return start;
    else
    {
        start = start + (number % 10);
        number = number / 10;
        return SumDigits(number, start);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(num, 0));
