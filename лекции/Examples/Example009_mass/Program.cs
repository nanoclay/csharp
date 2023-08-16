int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;


}// индексы 0,1,2,3,4,5,6,7,8
int[] mas ={1,2,3,4,5,6,7,8,9};
// ввод в массив

// поиск максимального числа в массиве
int max = Max(
    Max(mas[0], mas1[1], mas[2]),
    Max(mas[3], mas[4], mas[5]),
    Max(mas[6], mas[7], mas[8]));

Console.WriteLine(max);