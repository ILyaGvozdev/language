// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// // Конструктор строки вида string(char []) не использовать.
// // Пример
// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


string CharsToString(char[] chars)
{
    string str ="";
    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];
    }
    return str;
}

// char[] chars = {'a', 'b', 'c', 'd'};
// System.Console.WriteLine(CharsToString(chars));


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]


char[] StringToChars(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintChars(char[] chars)
{
    for (int i=0;i<chars.Length;i++)
    {
        Console.Write($" {chars[i]} ");
    }
}

// string str = "Hello!";
// PrintChars(StringToChars(str));


// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    int count = new int();
    string spisokVowels = "aeiouy";
    for (int i = 0; i < str.Length; i++)
    {
        if (spisokVowels.Contains(str[i])) count++;
        else continue;
    }   
    return count;
}

string str = "Hello!";
System.Console.WriteLine(CountVowels(str));