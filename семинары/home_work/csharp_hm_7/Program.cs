// ﻿Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] CreateArrey2dDouble (int rows, int colums)
{
   int [,] arrey = new [rows, colums];

   for (i = 0; i < rows; i++)
   {
      for (j = 0; j < colums; j++)
      {
           arrey[i,j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return arrey;
}

void PrintArrey2dDouble (double [,] array)
{
   for (i=0; i < arrey.GetLength(0); i++)
   {
      for(j=0; j < arrey.GetLength(1); j++)
      {
         Console.Write(arrey[i,j]);
      }
   Console.WriteLine();
   }
}
   
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] myArrey = CreateArrey2dDouble(m, n);
PrintArrey2dDouble(myArrey);



Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
