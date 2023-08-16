int[] CreateMasRandom(int size, int min, int max)
{
    int[] mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
    }
    return mas;
}

void WriteMas (int[] mas1)
{
    for(int i = 0; i < mas1.Length; i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();
    
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);
WriteMas(myMas);





//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateMasRandom(int size)
{
    int[] mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
}

void WriteMas (int[] mas1)
{
    for(int i = 0; i < mas1.Length; i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();
    
}

int Chet (int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0) count += 1;
    }
    return count;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size);
WriteMas(myMas);
Console.WriteLine(Chet(myMas));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateMasRandom(int size)
{
    int[] mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 10);
    }
    return mas;
}

void WriteMas (int[] mas1)
{
    for(int i = 0; i < mas1.Length; i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();
    
}

int Sum (int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0) count = count + mas[i]; 
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size);

WriteMas(myMas);
Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + Sum(myMas));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
/*

double[] CreateMas(int size)
{
    double[] mas = new double[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите " + (i+1) + " вещественное число: ");
        mas[i] = Convert.ToDouble(Console.ReadLine());
    }
    return mas;
}

void WriteMas (double[] mas1)
{
    for(int i = 0; i < mas1.Length; i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();
    
}

double Raznica (double[] mas)
{
    double min = mas[0];
    double max = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (min > mas[i]) min = mas[i];
        if (max < mas[i]) max = mas[i];
    }
    double count = max - min;
    return count;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myMas = CreateMas(size);
WriteMas(myMas);
Console.WriteLine(Raznica(myMas));
*/

