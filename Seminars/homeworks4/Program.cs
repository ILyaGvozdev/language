// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.


// void GetNumber()
// {
//     while (true)
//     {
//         System.Console.Write("Введите целое число: ");
//         string number = Console.ReadLine();
//         int sum=0;
//         for (int i = 0; i < number.Length; i++)
//         {
//             sum = sum + (number[i]-'0'); 
//         }
//         if (number == "q" || sum%2==0)
//         {
//             break;
//         }
//         System.Console.WriteLine("Для выхода введите q или число  сумма цифр которого чётная." );
//     }
// }
// GetNumber();


// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateRandomArray(int size)
// {

//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999 + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("Массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void EvenToArray(int[] array)
// {
//     int count= new int();
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==0) count++;
//     }
//     System.Console.WriteLine($"Количество чётных чисел в массиве: {count}");
// }



// System.Console.WriteLine("Введите размер массива состоящего из 3ёх значных чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// PrintArray(array);
// EvenToArray(array);




// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// int[] CreateRandomArray(int size, int min, int max)
// {

//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// int[] ReverseArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[array.Length - i - 1];
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("Массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void PrintArrayReverse(int[] array)
// {
//     System.Console.Write("Обратный массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }


// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// int[] newArray = ReverseArray(array);
// PrintArrayReverse(newArray);