// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

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



string CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return "Да";
    }
    return "Нет";

}





// System.Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);

// System.Console.WriteLine("Input element to find: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckNumInArray(array, num));


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

int[] PlusToMinus(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

// PrintArray(PlusToMinus(array));


// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] PairsCount(int[] array)
{
    int[] tempArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempArray[i] = array[i] * array[array.Length - i - 1];
    }
    return tempArray;
}

// System.Console.WriteLine("Сумма произведение пар и новый массив: ");
// PrintArray(PairsCount(array));



// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]


int[] NumToArray(int num)
{
    if (num >= 100 && num <= 999)
    {
        int[] array = new int[3];
        int ed = num % 10;
        int dec = num / 10 % 10;
        int sot = num / 100;
        array[0] = ed;
        array[1] = dec;
        array[2] = sot;
        return array;
    }
    else
    {
        System.Console.WriteLine("You input not 3 digit num");
        return null;
    }
    
}

System.Console.WriteLine("Input three-digit num: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(NumToArray(num));

