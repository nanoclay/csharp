void FillArray(int[] collection) //создали метод с заполнением рандомными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)  //создали метод печати чисел из массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection,int find)  //метод поиска числа в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            posision = index;
            break;
        }
        index++;
    }
    return position;
}



int [] array = new int[10]; //создали масив из 10 чисел

FillArray(array); //первый метод для зполнения числами
PrintArray(array); //метод для печати чисел