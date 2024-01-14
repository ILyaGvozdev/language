// 1. Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.


// void cratnost(int num)
// {
//     if(num%7==0 && num%23==0)
//         System.Console.WriteLine($"{num} кратно числам 7 и 23");
//     else
//         System.Console.WriteLine($"{num} не кратно числам 7 и 23");
// }

// System.Console.WriteLine("Введите число на проверку кратности 7 и 23: ");
// int number = Convert.ToInt32(Console.ReadLine());
// cratnost(number);






// 2. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
//   в которой находится эта точка.

// void numOfChetvert(int num1, int num2)
// {
//     if(num1>0 && num2>0)
//         System.Console.WriteLine($"Точка находится в 1ой координатной четверти");
//     else if(num1<0 && num2>0)
//         System.Console.WriteLine($"Точка находится в 2ой координатной четверти");
//     else if(num1<0 && num2<0)
//         System.Console.WriteLine($"Точка находится в 3ой координатной четверти");
//     else
//         System.Console.WriteLine($"Точка находится в 4ой координатной четверти");
// }

// System.Console.WriteLine("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// numOfChetvert(x,y);






// // 3. Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// //  и показывает наибольшую цифру числа.


// void maxOfNum(int num)
// {
//     if(num/10 > num%10)
//         System.Console.WriteLine($"Наибольшая цифра в числе {num} -> {num/10}");
//     else
//         System.Console.WriteLine($"Наибольшая цифра в числе {num} -> {num%10}");
// }


// int number = new Random().Next(10,99+1);
// maxOfNum(number);









// 4. Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

// Вообще странно, почему в "Идеальном решении" числа в обратном порядке идут. Ну ладно.


// void reNum(int num)
// {
//     if (num < 10)
//         System.Console.WriteLine($"Число {num} меньше 10");
//     else
//     {
//         System.Console.WriteLine($"Цифры числа {num} через запятую: ");
//         for (int i = 1; i < num; i += 1)
//         {
//             System.Console.Write($"{num%10}, ");
//             num=num/10;
//         }
//         System.Console.Write($"{num} ");
//     }
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// reNum(number);