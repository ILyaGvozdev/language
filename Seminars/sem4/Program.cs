// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int[] CreateRandomArray(int size, int min, int max)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int SimpleNumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] != 1 && array[i] % 2 != 0 || array[i] == 2)
            if (array[i] % 3 != 0 || array[i] == 3)
                if (array[i] % 5 != 0 || array[i] == 5)
                    if (array[i] % 7 != 0 || array[i] == 7)
                        count++;

    }
    return count;
}

// System.Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max); 
// // PrintArray(array);
// System.Console.WriteLine($"Количество чисел {NumCounter(array)}");




// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

int NumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0) count++;
    }
    return count;
}


// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


int ArrayToNum(int[] array)
{
    string str = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];
    }
    // System.Console.WriteLine(str);
    return Convert.ToInt32(str);
}

int ArrayToNum2(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)(array[i] * Math.Pow(10, array.Length - i - 1));
        sum += array[i];
    }
    return sum;
}

System.Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(ArrayToNum2(array));


