// void numToQuad(int num)
// {
//     System.Console.WriteLine(num * num);
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// numToQuad(number);

// int numToQuad(int num)
// {
//     return num * num;
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// // int result = numToQuad(number);
// // System.Console.WriteLine(result);

// System.Console.WriteLine(numToQuad(number));





// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// void deleteSecondDigit(int num)
// {
//     if(num >=100 && num <= 999)
//     {
//         System.Console.WriteLine($"{num} -> {num/100}{num%10}");
//     }
//     else
//     {
//         System.Console.WriteLine("You input not 3 digit num");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// deleteSecondDigit(number);






// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


// int secondToThird(int num)
// {
//     if(num >=100 && num <= 999)
//     {
//         int ed = num%10;
//         int dec = num/10%10;
//         int result=dec;
//         System.Console.WriteLine($"число {dec}");
//         System.Console.WriteLine($"в степень {ed}");
//         for (int i=1;i<ed;i++)
//         {
//             result = result*dec;
//         }
//         return result;
//     }
//     return 0;
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(secondToThird(number));









// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void cratnost(int num1, int num2)
// {
//     if(num1%num2==0)
//     {
//         System.Console.WriteLine($"{num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"остаток от деления {num1} на {num2} = {num1%num2}");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// cratnost(number1,number2);