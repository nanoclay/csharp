// seminar 2

//info
/*

13253 / 10 = 1325
13253 / 100 = 132
13253 / 1000 = 13
13253 / 10000 = 1

13253 % 10 = 3
13253 % 100 = 53
13253 % 1000 = 253
13253 % 10000 = 3253

24365

24365 % 10000 / 100 = 43

// && - и 
// || - или

*/

//Task 1. Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру это числа.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int res = hundreds * 10 + units;
    return res;

    //return hundreds * 10 + units;
}

int randNumber = new Random().Next(100, 1000); // генератор рандомных чисел

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

//Task 2. Напишите программу, которая
// принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool IsDividable (int num, int div1, int div2)
{
    if(num % div1 == 0 && num % div2 == 0)
        return true;
    else
        return false;

    // return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first for checking: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second for checking: ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = IsDividable(number, a, b);

if(res)
    Console.Write("Yes");
else
    Console.Write("No");
*/

//Task 3. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
/*
int Maxcif (int numRandom)
{
    if(numRandom / 10 > numRandom % 10)
    {
        return numRandom / 10;
    }
    else
    {
        return numRandom % 10;
    }
}

int randNumber = new Random().Next(10, 99);

int maxtwo = Maxcif(randNumber);

Console.WriteLine(randNumber + " -> " + maxtwo);
*/

//Task 4. Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
/*
bool Kvadrat (int num1, int num2)
{
    return num1*num1 == num2 || num2*num2 == num1;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool res = Kvadrat(number1, number2);

if (res)
   Console.Write("одно число является квадратом второго");
else
   Console.Write("ни одно число не является квадратом второго");
   */