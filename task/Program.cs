/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
using System;
using static System.Console;

int GetLenghtNewStringArray(string[] text)
{
    int lenght = 0;
    for (int i = 0; i < text.Length; i++)
    {
        string element = text[i];
        if (element.Length < 4)
        {
            lenght++;
        }
    }
    return lenght;
}

string[] GetNewStringArray(string[] text, int lenght)
{
    string[] newText = new string[lenght];
    int j = 0;
    for (int i = 0; i < text.Length; i++)
    {
        string element = text[i];
        if (element.Length < 4)
        {
            newText[j] = element;
            j++;
        }
    }
    return newText;
}

Clear();
string[] text = { "hello", "2", "world", ":-)" };
int lenght = GetLenghtNewStringArray(text);
string[] newText = GetNewStringArray(text, lenght);
Write($"[{String.Join(", ", text)}] -> [{String.Join(", ", newText)}]");
