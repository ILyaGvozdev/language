// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.

// System.Console.WriteLine("Задайте число m: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Задайте число n: ");
// int n = int.Parse(Console.ReadLine());
// System.Console.Write($"Промежуток от {m} до {n} - ");
// Interval(m, n);

// void Interval(int m, int n)
// {
//     if (m<=n)
//     {        
//         System.Console.Write(m + " ");
//         Interval(m+1,n);
//     }
    
// }


// Задача 2: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.



// int Akkerman(int m, int n)
// {
//     if (m==0) return n+1;
//     else if (n==0) return Akkerman(m-1,1);
//     else return Akkerman(m-1, Akkerman(m, n-1));
// }


// System.Console.Write("Задайте число m: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.Write("Задайте число n: ");
// int n = int.Parse(Console.ReadLine());
// System.Console.Write($"Функция Аккермана с переменными m={m} и n={n} равна {Akkerman(m, n)}");


// Задача 3: Задайте произвольный массив.
//  Выведете его элементы, начиная с конца. 
//  Использовать рекурсию, не использовать циклы.

// int[] CreateRandomArray(int size, int min, int max)
// {

//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void PrintArrayRe(int[] array, int i)
// {
//    if(i>0)
//    {
//     System.Console.Write(array[i-1]+ " ");
//     PrintArrayRe(array, i - 1);
//    }
// }

// System.Console.WriteLine("Введите длинну массива");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимально возможное число в массиве");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное возможное число в массиве");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max); 
// System.Console.WriteLine("Массив");
// PrintArray(array);
// System.Console.WriteLine("Рекурсивный вывод");
// PrintArrayRe(array,size);