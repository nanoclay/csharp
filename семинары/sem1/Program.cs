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
