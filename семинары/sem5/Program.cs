//Tusk 1. Задайте массив из m элементов, заполненный случайными числами из промежутка [a, b]. Найдите сумму отрицательных элементов массива.
/*
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

int SumMinus(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];    
    }
    return sum;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);
WriteMas(myMas);
Console.WriteLine(SumMinus(myMas));
*/

//Tusk 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
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

int[] Zamena(int[] myMas)
{
    for (int i = 0; i < myMas.Length; i++)
    {
        myMas[i] *= -1;
    }
    return myMas;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);
WriteMas(myMas);

Zamena(myMas);
WriteMas(myMas);
*/

//Tusk 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
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

bool Proverka (int[] massivchik, int number)
{
    bool count = false;
    for (int i = 0; i < massivchik.Length; i++)
    {
        if (massivchik[i] == number)
        {
            count = true;
            break;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);
WriteMas(myMas);

Console.Write("Введите число для проверки массива: ");
int num = Convert.ToInt32(Console.ReadLine());


bool res = Proverka(myMas, num);
if (res)
   Console.Write("да");
else
   Console.Write("нет");
*/

//Tusk 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
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

int Sum (int[]mas, int a, int b)
{int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if ( a <= mas[i] && mas[i] <= b) count += 1;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);
WriteMas(myMas);

Console.Write("Введите первое число отрезка: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число отрезка: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(myMas, a, b));
*/




















//изучить
/*int Prompt(string message)          
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
*/
