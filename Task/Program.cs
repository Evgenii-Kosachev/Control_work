/*
    Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/



string[] SelectData(string[] data, int lengthElement)
{
    int count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= lengthElement) count++;
    }

    string[] result = new string[count];

    count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= lengthElement)
        {
            result[count] = data[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i >= 0 && i < data.Length - 1) Console.Write($"\"{data[i]}\", ");
        if (i == data.Length - 1) Console.Write($"\"{data[i]}\"]");
    }

    if (data.Length == 0) Console.Write("[]");
}

string[] userData = {"hello", "2", "world", ":-)"};

PrintArray(SelectData(userData, 3));

/*
    ["hello", "2", "world", ":-)"]
    ["1234", "1567", "-2", "computer scince"]
    ["Russia", "Denmark", "Kazan"]
*/