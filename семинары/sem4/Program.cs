// Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
/*
int PrintSum (int num)
{ 
    
    int i = 0;
    int current = 0;
    while (i <= num)
    {
        current = current + i;
        i = i + 1;
    }
    return current;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) Console.WriteLine("Некорректный ввод!");
else Console.WriteLine(PrintSum(number));
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
/*
void Numbers (int num)
{
    int i = 1;
    while (num > 10)
    {
        num = num / 10;
        i++;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Numbers(number);
*/

// Tusk 3. Напишите программу, которая принимает на вход число N и выдаёт произведение нечетных чисел от 1 до N.
/*
void Proiz (int num)
{
    int i = 1;
    int current = 1;
    while (current <= num)
    {
        i = i * current;
        current+= 2;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Proiz(number);
*/

// Tusk 4.
int[] CreateMasRandom(int size, int min, int max)    //создаем массив
{
    int[] mas = new int[size];    //выделение памяти!    тип массива int, [] - массив, название, [] размер массива инициализаия

    for(int i = 0; i < size; i++)    //цикл for, переменная i создается для for, логическое условия i < size так как начинается с 0, увеличиваем счетчик
    // можно брать эти блоки из другого места но оставлять ";", блоки можно добавлять через ","
    {
        mas[i] = new Random().Next(min, max + 1); // i начинается с 0 как и первый индекс массива. у max+1 так как верхний предел не уитывается
    }
    return mas;
}

void WriteMas (int[] mas1 )
{
    for(int i = 0; i < mas1.Length; i++)               // размер size массива mas1.Length
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();                        // Перейти на сл сроку после вывода массива
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = CreateMasRandom(size, min1, max1);    //моздаем массив, используя метод рандомного заполнения
WriteMas(myMas);                                    //выведем наш массив используя метод вывода массива

