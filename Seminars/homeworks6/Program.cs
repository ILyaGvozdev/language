// Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.



// void PrintArrayToString(char[,] array)
// {   
//     string str ="";
//     foreach (char e in array)
//     {
//         str+=e;
//     }
//     System.Console.WriteLine(str);
// }

// char[,] array = {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'},
// };

// PrintArrayToString(array);




// Задача 2: Задайте строку, содержащую
//  латинские буквы в обоих регистрах. 
//  Сформируйте строку, 
//  в которой все заглавные буквы заменены на строчные.

// System.Console.WriteLine("Введите строку, содержащую латинские буквы малого и большого регистров: ");
// string str = Console.ReadLine();
// System.Console.WriteLine($"Ваш текст фул смол регистр - {ChangeToLower(str)}");

// string ChangeToLower(string str)
// {
//     string lowString = str.ToLower();
//     return lowString;
// }




// Задача 3: Задайте произвольную строку.
//  Выясните, является ли она палиндромом.

// System.Console.WriteLine("Введите строку: ");
// string str = Console.ReadLine();

// string Polindrom(string str)
// {
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i]!= str[str.Length - i - 1])
//         {
//             return "Не полиндром";
//         }
//     }
//     return "Полиндром";
// }

// System.Console.WriteLine(Polindrom(str));


// Задача 4*(не обязательная): Задайте строку, 
// состоящую из слов, разделенных пробелами. 
// Сформировать строку,
//  в которой слова расположены в обратном порядке. 
//  В полученной строке слова должны быть также разделены пробелами.

// System.Console.WriteLine("Введите строку состоящую из слов, разделенных пробелами.: ");
// string str = Console.ReadLine();

// string ReverseWords(string str)
// {
//     string strReverse1 = "";
//     string strReverse2 = "";
//     for (int i = 0; i < str.Length; i++)
//     {
//         strReverse1 += str[str.Length - i - 1];
//     }
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (strReverse1[i] == ' ')
//         {
//             for (int j = 0; j < i; i++)
//             {
//                 strReverse2+=strReverse1[i];
//             }
//         }
//         strReverse1 = strReverse1.Remove(0, i+1);
//     }
//     return strReverse2;
// }

// System.Console.WriteLine(ReverseWords(str));

// Посмотрел потом идеальное решение. И понял что я чёт 4ое задание усложнил в х100))