// функция нахождения максимального
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// вводимые значения
int a1 = 123;
int b1 = 213123;
int c1 = 4213;
int a2 = 1233;
int b2 = 332;
int c2 = 56;
int a3 = 678;
int b3 = 6789;
int c3 = 345345;

// использование этой функции в коде
/*
int max1 = Max(a1, b1, c1)
int max2 = Max(a2, b2, c2)
int max3 = Max(a3, b3, c3)
int max = Max(max1, max2, max3)
*/


//Использование функции в одну строку
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));


// Вывод максимального числа
Console.WriteLine(max);
