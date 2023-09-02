// Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int [,] CreateRandom2dArrey()
{
    
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] arrey = new int[rows, colums];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            arrey [i, j] = new Random().Next(minValue, maxValue+1); 
    }
    return arrey;
}

void Show2dArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(1) &&
       r1 != r2)
       {
            for( int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[r1, j];
                array[r1, j] = array[r2, j];
                array[r2, j] = temp;
            }
       }
}

int [,] Mas = CreateRandom2dArrey();
Show2dArrey(Mas);

Console.WriteLine("Введите строку для замены");
int rows1 = Convert.ToInt32(Console.ReadLine()) - 1; 
Console.WriteLine("Введите строку для замены");
int rows2 = Convert.ToInt32(Console.ReadLine()) - 1; 

ChangeRows(Mas, rows1, rows2);
Show2dArrey(Mas);
*/

//Task 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
// 1 2 3
// 4 5 6
// 7 8 9

// 1 4 7
// 2 5 8
// 3 6 9

int [,] CreateRandom2dArrey()
{
    
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] arrey = new int[rows, colums];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            arrey [i, j] = new Random().Next(minValue, maxValue+1); 
    }
    return arrey;
}

void Show2dArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}

int [,] Diag (int[,] array)
{
    int[,] revers = new int[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            revers[j, i] = array[i,j];
        }
    }   
    return revers;
}

void Diag2 (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int [,] Mas = CreateRandom2dArrey();
Show2dArrey(Mas);
Console.WriteLine();
Diag2(Mas);
Show2dArrey(Mas);
*/

// Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int [,] CreateRandom2dArrey()
{
    
    Console.WriteLine("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] arrey = new int[rows, colums];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            arrey [i, j] = new Random().Next(minValue, maxValue+1); 
    }
    return arrey;
}

void Show2dArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}

int[,] Del (int[,] array)
{
    int indexRows = 0;
    int indexColums = 0;
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] < array[indexRows, indexColums])
            {
                indexRows = i;
                indexColums = j;
            }
    Console.WriteLine(indexRows);
    Console.WriteLine(indexColums);
    Console.WriteLine();

    int[,] del = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for (int i = 0, i1 = 0; i < del.GetLength(0); i++, i1++)
        for (int j = 0, j1 = 0; j < del.GetLength(1); j++, j1++)
        {
            if(i1 == indexRows)
                i1++;
            if(j1 == indexColums)
                j1++;
            
            del[i,j] = array[i1,j1];
        }
    return del;
}


int [,] Mas = CreateRandom2dArrey();
Show2dArrey(Mas);
Console.WriteLine();
int [,] Delete = Del(Mas);
Show2dArrey(Delete);