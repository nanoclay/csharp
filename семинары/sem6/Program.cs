// Teory
/*
void ShowNum(int[] nums)  // в методе fhuevtyn (мааасив) не копируется, а используется основной (значчимый, не ссылка)
{
    nums[0] += 10;
    Console.WriteLine(nums[0]);
}

int[] numbers = {5, 7, 8};

ShowNum(numbers);        // 15

Console.WriteLine(numbers[0]);  // 15
*/

// Tusk 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] RandomMas(int size, int min, int max)
{
    int[] mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
    }
    return mas;
}

void PrintMas(int[] mas)
{
    for(int i = 0; i < mas.Length; i++)
        Console.Write(mas[i]);
}

void Revers(int[] mas)
{
    int temp = mas[i];
    mas[i] = mas[mas.Length - 1 - i];
    mas[mas.Length - 1 - i] = temp;
}

//void Revers2(int[] mas)
{
    for(int i = 0, j = mas.Lenght - 1; i < j; i++, j--)
    {
        int = temp = mas[i];
        mas[i] = mas[j];
        mas[j] = temp;
    }
}

Console.Write("Введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myMas = RandomMas(size1, min1, max1);
PrintMas(myMas);
*/

// Tusk 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Treug (int a, int b, int c)
{
    if (a > 0 && b > 0 && c > 0)
    {
        if (a + b > c && a + c > b && b + c > a)
            return true;
        else return false;
    }
    else return false;
}

Console.WriteLine("Укажите длинну стороны A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите длинну стороны B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите длинну стороны C");
int c = Convert.ToInt32(Console.ReadLine());

bool fin = Treug(a, b, c);

if (fin == true) Console.WriteLine("Такой треугольник существует");
else Console.WriteLine("Такой треугольник не существует!");
*/

// Tusk 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] Feb(int size)
{
    int[] mas = new int[size];
    mas[0] = 0;
    mas[1] = 1;

    for (int i = 2; i < size; i++)
    {
        mas[i] = mas[i-1] + mas[i-2];
    }
    return mas;
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i]);
    }
}


Console.Write("Введите колличество чисел:");
int n = Convert.ToInt32(Console.ReadLine());

int[] Mas = Feb(n);
PrintMas(Mas);
*/

// Tusk 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] Copy(int[] Mas)
{
    int[] Array = new int[Mas.Length];
    for (int i = 0; i < Mas.Length; i++)
    {
        Array[i] = Mas[i];
    }
    return Array;
}

int[] RandomMas(int size, int min, int max)
{
    int[] Mas = new int[size];

    for(int i = 0; i < size; i++)
    {
        Mas[i] = new Random().Next(min, max + 1);
    }
    return Mas;
}

void PrintMas(int[] Mas)
{
    for(int i = 0; i < Mas.Length; i++)
        Console.Write(Mas[i]);
        Console.WriteLine(" ");
}

Console.Write("Введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] MyMas = RandomMas(size1, min1, max1);

int[] OurMas = Copy(MyMas);
MyMas[5] = MyMas[5] + 1;

PrintMas(MyMas);

PrintMas(OurMas);
*/

