// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double [,] CreateDouble2dArray()
{
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    double [,] array = new double [rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = Math.Round (minValue + (maxValue - minValue) * new Random().NextDouble(), 2);
    
    return array;
}

void Show2dArray (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double [,] myArray = CreateDouble2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void ShowNumArrey (int [,] Arrey)
{
    Console.Write("Введите номер строки: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a <= Arrey.GetLength(0) && b <= Arrey.GetLength(1))
        Console.WriteLine(Arrey[a,b]);
    else Console.WriteLine("такого индекса в массиве нет");
}

int [,] Mas = CreateRandom2dArray();
Show2dArray (Mas);
ShowNumArrey(Mas);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray (int[,] arrey)
{
    for(int i = 0; i < arrey.GetLength(0); i++)
    {
        double sum = 0;
        for(int j = 0; j < arrey.GetLength(1); j++)
        {
            sum += arrey[i,j];
            Console.Write(arrey[i,j] + " ");
        }
        Console.WriteLine($" -> {sum / arrey.GetLength(0)}");
    }
}

int [,] Mas = CreateRandom2dArray();
Show2dArray (Mas);
*/
