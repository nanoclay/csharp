//Задача 2
/*
 Console.Write("Введите первое число:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 < num2) Console.WriteLine("Большее из двух чисел: " + num2);
else Console.WriteLine("Большее из двух чисел: " + num1);

// Переменная double, т.к. в задаче не указано, что число целое
*/

//Задача 4
/*
Console.Write("Введите первое число:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число:");
double num3 = Convert.ToDouble(Console.ReadLine());

double big = 0;

if (num1 > num2) big = num1;
if (num2 > num3) big = num2;
if (num3 > num1) big = num3;

Console.WriteLine("Самое больше из трёх чисел: " + big);
*/

//Задача 6
/*
Console.Write("Введите ваше число:");
int num = Convert.ToInt32(Console.ReadLine());

num = num % 2;

if (num == 0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");
}
*/

//Задача 8
/*
Console.Write("Введите ваше число:");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
int current1;

while(current <= num)
{
    current1 = current % 2;
    if (current1 == 0)
    {
        Console.Write(current+ " ");
    }
    current++;
}
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int TwoNum (int num)
{
    
    return num / 10 % 10; 
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int printNum = TwoNum(number);
Console.Write(printNum);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа ( или -1, если третьей цифры нет)
/*
int ThreeNum (int num)
{
    return num % 10;

}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.Write("-1");
else
    Console.Write("Третья цифра в числе: "+ThreeNum(number));
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
/*
bool Test (int num)
{
    return 5 < num;
}

Console.Write("Введите день недели цифрой: ");
int number = Convert.ToInt32(Console.ReadLine());

bool otvet = Test(number);
if (otvet) Console.Write("Выходной день");
else Console.Write("Рабочий день");
*/

//Задача Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
bool Miror (int num)
{
    if (num < 10) return false;
    else
    {
        int nextNum = 0;
        while (num > 10) 
        {
            
            int numLeft = num;                        
            while (numLeft > 10)
            {
                numLeft = numLeft / 10;
            }
            if (numLeft != num % 10) return false;
            while (numLeft < num)
            {
                nextNum = numLeft;
                numLeft = numLeft * 10;
            }
            num = (num - nextNum) / 10;
        }
        return true;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool otvet = Miror(number);

if (otvet) Console.Write("Ваше число палиндром");
else Console.WriteLine("Ваше число не является палиндромом");
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Metod (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaA = x1 - x2;
    double deltaB = y1 - y2;
    double deltaZ = z1 - z2;


    double dist = Math.Sqrt(deltaA * deltaA + deltaB * deltaB + deltaZ * deltaZ);
    return dist;
}
Console.WriteLine("введите x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите z2");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите z2");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Metod(x1, y1, z1, x2, y2, z2), 2));
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
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
        Console.WriteLine(i*i*i);
        i++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Quadrat(num);
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int Pow (int a, int b)
{
    int startnumber = a;
    for(int i = 1; i < b; i++)
    {
        a = a * startnumber;
    }
    return a;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(Pow(a, b));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int Sum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(number));
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int[] CreateMas(int size, int min, int max)
{
    int[] mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите " + (i+1) + " число: ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}

void WriteMas (int[] mas1 )
{
    for(int i = 0; i < mas1.Length; i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();    
}

Console.Write("Введите размер массива: ");
int sizeMas = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMas(sizeMas, minNum, maxNum);
WriteMas(myMas);
*/
