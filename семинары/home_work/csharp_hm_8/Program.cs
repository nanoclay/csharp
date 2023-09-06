// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int u = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[u, n];
    for(int i = 0; i < u; i++)
        for(int j = 0; j < n; j++)
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

void Sort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1 ; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

Sort(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int u = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[u, n];
    for(int i = 0; i < u; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int MinNumu(int[,] array)
{
    int minNum = 0;
    int minu = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        minNum += array[0, i];

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int count = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            count += array[i, j];
        }
        if (count < minNum)
        {
            minu = i;
            minNum = count;    
        }
    }
    return minu;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
Console.WriteLine($"{MinNumu(myArray)+1} строка");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int u = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[u, n];
    for(int i = 0; i < u; i++)
        for(int j = 0; j < n; j++)
            array[i, j] = new Random().Next(0, 10);
    
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] Matrix(int[,] Mas1, int[,] Mas2)
{
    int[,] Matr = new int[Mas1.GetLength(0), Mas2.GetLength(1)];

    for (int i = 0; i < Mas1.GetLength(0); i++)
    {
        for (int j = 0; j < Mas2.GetLength(1); j++)
        {
            for (int l = 0; l < Mas2.GetLength(0); l++)
            {
                Matr[i, j] += Mas1[i, l] * Mas2[l, j];
            }
        }
    }
    return Matr;

}

Console.WriteLine("ВВОД ПЕРВОЙ МАТРИЦЫ");
int[,] MyArray1 = CreateRandom2dArray();
Console.WriteLine("ВВОД ВТОРОЙ МАТРИЦЫ");
int[,] MyArray2 = CreateRandom2dArray();
Console.WriteLine();
Show2dArray(MyArray1);
Console.WriteLine();
Show2dArray(MyArray2);

if(MyArray1.GetLength(1) == MyArray2.GetLength(0))
{
    int[,] Matr = Matrix(MyArray1, MyArray2);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц:");
    Console.WriteLine();
    Show2dArray(Matr);
}
else
    Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй матрицы");
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*

int[,,] CreateRandom3dArray(int u, int n, int sloys)
{
    int[,,] array = new int[u, n, sloys];
    int[] Num = new int[u * n * sloys];
    for(int i = 0; i < Num.Length; i++)
    {
        while(Num[i] == 0)
        {
            int current = new Random().Next(10, 100);
            bool end = false;
            for(int j = 0; j <= i; j++)
            {
                if(end == true) break;
                if (current == Num[j]) end = true;
            }
            if(end == false) Num[i] = current;
        }
    }

    int cur = 0;
    for(int i = 0; i < u; i++)
        for(int j = 0; j < n; j++)
            for(int l = 0; l < sloys; l++, cur++)
            {
                array[i, j, l] = Num[cur];
            }
    return array;
}

void Show3dArray (int[,,] array)
{
    for(int l= 0; l < array.GetLength(2); l++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, l]}({i},{j},{l})");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество слоев: ");
int s = Convert.ToInt32(Console.ReadLine());
if(r*c*s < 100)
{
    int [,,] myArray = CreateRandom3dArray(r, c, s);
    Show3dArray(myArray);
}
else Console.Write("Генерация массива невозможна");

*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Spiral2dMas (int[,] array, int size)
{
   int value = 1;
   int i = 0;
   int j = 0;
   while(value <= size * size)
   {
    array[i,j] = value;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i< j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
        else
            i--;
        value++;
   }
}

void Show2dArray (int[,] array, int size)
{
    Console.WriteLine($"Массив, имеющий размер {size} x {size}, заполнен по спирали.");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < 10) Console.Write("0"+ array[i,j] + " ");
            else Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Введите размерность массива: " );
int size = Convert.ToInt32(Console.ReadLine());

int [,] myMas =  new int[size, size];

Spiral2dMas(myMas, size);
Show2dArray(myMas, size);