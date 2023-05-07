/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine()!;
}

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введи значение элемента {i+1}: ");
    }

    return array;
}

int CountWordsWithLessThan3Symbols(string[] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CopyOnlyLessThan3Symbols(string[] initialArray)
{
    int copySize = CountWordsWithLessThan3Symbols(initialArray);
    string[] newArray = new string[copySize];

    int count = 0;
    foreach (string str in initialArray)
    {
        if (str.Length <= 3)
        {
            newArray[count++] = str;
        }
    }

    return newArray;
}

void ShowArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int size = Int32.Parse(Prompt("Привет! Введи размер массива: "));
string[] array = FillArray(size);
string[] duplicate = CopyOnlyLessThan3Symbols(array);
ShowArr(duplicate);
