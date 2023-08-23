//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
int Input(int size)
{
    int count = 0;
    int j =0;
    for (int i = 0; i < size; i++)
    {
        Console.Write("введите " + (i + 1) + " число: ");
        count = Convert.ToInt32(Console.ReadLine());
        if (count > 0) j++;
    }
    return j;
}

Console.Write("введите колличество чисел: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int num = Input(sizeArray);
Console.WriteLine("Колличество чисел больше нуля: " + num);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
string Geometry (double b1, double k1, double b2, double k2)
{
    string geo;
    if (k1 == k2 && b1 == b2) 
    {
        geo = "совпадают";
        return geo;
    }    
    else
    {
        if ((k1 == k2 && b1 != b2) || (k1 != k2 && b1 == b2))
        {
            geo = "Параллельны";
            return geo;
        }  
        else
        {
            double x = Math.Round((b2-b1)/(k1-k2), 2);
            double y = Math.Round(k1*(b2-b1)/(k1-k2)+b1, 2);
            geo = "Пересекают в точке: " + x + "; " + y;
            return geo;
        }
    }
}

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Geometry(b1, k1, b2, k2));
*/

//Задача $:Написать программу, преобразующую число из десятеричной системы счисления в двоичную.

/*
string TwoSistem (int num)
{
    string count = "";
    while(num > 0)
    {
        count = num % 2 + count;
        num /= 2;
    }
    return count;
}

Console.WriteLine("Введите число в двоичной системе: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TwoSistem(number));
*/