//метод 1 (берет данные и ничего не возвращает)
/*
void Method1(string msg)
{
    Console.WriteLine(msg);
}

Method1("привет");
*/

//метод2
/*
void Method2(string msg, int count)   //именование аргументов
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2(count: 4, msg:"текст");      //использование наименований аргументов
*/

//метод 3 (ничего не принимает, но возвращает)
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();

Console.WriteLine(year);
*/

//метод 4 (принимает и возвращает)
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);
*/



// использование for
/*
string Method4(int count, string text)
{
       string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);
*/

// цикл в цикле
/*
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//замена символов
/*
//Дан текст. В котором нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + " ежели бы вас поСлали вместо нашего милого Винцегрероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так краСноречивы. Вы дадите мне чаю?";

//   sting s = "qwerty"
//индекс строки 012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();

string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);
Console.WriteLine();
*/

//сортировка в массиве

//вывод массива на экран
/*

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
*/
//сортировка
/*
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(arr);
*/
//сортировка
/*
void MaxMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

MaxMin(arr);
PrintArray(arr);
*/