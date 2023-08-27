//поиск индекса в массиве


int[] mas = {12,3,1,4,23,5};

int n = mas.Length;
int find = 23; // вводимое число

int index = 0;

while (index < n)
{
    if(mas[index] == find)
    {
        Console.WriteLine(index);
        break;
        // закончить цикл после первого вывода
    }
    // счетчик+1
index++;
}