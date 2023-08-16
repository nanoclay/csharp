// Теория
/*
// Math.Pow(число, степень) возведение в степень
// Math.Sqrt(число)  Корень
// Math.Round(вещественное число, сколько знаков после запятой)   округление числа
*/

// Tusk 1. Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).
/*
void WriteRange(int quadrant)
{
    if(quadrant < 1 || quadrant > 4) Console.WriteLine("Некорректный ввод"); //проверка "0 > quadrant < 5"
    else if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x < 0 and y > 0");
}
// Нет return т.к. не требуется вернуть значение в переменную или закончить метод
// одно из else требует запуска. После запуска одниго else остальные не будут рассматриваться 

Console.Write("Введите число: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad);
*/

// Tusk 2. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
void Metod (int x, int y)
{
    if (x == 0 && y == 0) Console.Write("Некоректный ввод!");
    else if (x >= 0 && y >= 0) Console.Write("четверть 1");
    else if (x <= 0 && y >= 0) Console.Write("четверть 2");
    else if (x <= 0 && y <= 0) Console.Write("четверть 3");
    else Console.Write("четверть 4");
}

Console.WriteLine("Введите x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:");
int y = Convert.ToInt32(Console.ReadLine());

Metod(x, y);
*/

// Tusk 3. Напишите программу, которая принимает на вход число (N) и выдаёт
// квадраты чисел от 1 до N.
/*
void Quadrat (int n)
{
    if (n < 1)
    {
       Console.WriteLine("Некорректный ввод!");
       return;
    } 
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine(i + " - " + i * i);
        i++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Quadrat(num);
*/

// Tusk 4. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
/*
double Metod (double x1, double y1, double x2, double y2)
{
    double deltaA = x1 - x2;
    double deltaB = y1 - y2;
    double dist = Math.Sqrt(deltaA * deltaA + deltaB * deltaB);
    return dist;
}
Console.WriteLine("введите x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Metod(x1, y1, x2, y2), 2));
*/
