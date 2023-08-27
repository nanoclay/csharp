/*
string[,] table = new string[2,5]; // создвем двумерный массив


// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1,2] = "слово";              // записали текст во вторую строку, третий столбец


// распечатали весь массив
for(int rows = 0; rows < 2; rows++)
{
    for(int colums = 0; colums < 5; colums++)
    {
        Console.Write($"{table[rows, colums]}.");
    }
    Console.WriteLine();
}




int[,] matr = new int[3, 4];


//создали метод для рандом заполнения двухмерного массива

void FillMas(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}

//создали метод для показа двухмерного массива

void PrintMas(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
}
}

PrintMas(matr);
FillMas(matr);
PrintMas(matr);
*/

int[,] pic = new int[,]  // создаем двумерный массив
{
    {0,0,0,0,0,0,0},
    {0,1,1,1,1,1,0},
    {0,1,0,0,0,1,0},
    {0,1,0,0,0,1,0},
    {0,1,0,0,0,1,0},
    {0,1,1,1,1,1,0},
    {0,0,0,0,0,0,0}
};

void PrintImage(int[,] image)  //показывает двумерный массив +
{
    for (int i = 0; i< image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void PaintImage(int row, int col) //закрашиваем с помощью рекурсии
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        PaintImage(row-1, col);
        PaintImage(row-1, col-1);
        PaintImage(row+1, col);
        PaintImage(row-1, col+1);
    }
}

PrintImage(pic);
PaintImage(4,4);
PrintImage(pic);

double Factorial (int n)        // факториал
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 3 ; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3
}




double Fibonacci (int n)            //фибоначчи
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci (n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 3; i++)
{
    Console.WriteLine($"Fibonacci {i} -> {Fibonacci(i)}");
}




