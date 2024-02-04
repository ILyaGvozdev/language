// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр(рекурсией)

int FindSum(int num)
{
    if(num>0)
    {
        return num % 10 + FindSum(num/10);
    }
    return 0;
}

// System.Console.WriteLine(FindSum(456));

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

void OneToN(int n)
{
    if (n>0)
    {
        OneToN(n-1);
        System.Console.Write(n + " ");
    }
}

// OneToN(5);

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, W, X, Z;
// b, c, d, f, g, h, j, k, l, m, n, p, q, r, s, t, v, w, x, z

void Consonants(string str, int i)
{
    if (i == str.Length) return;
    if (str[i] == 'b' || str[i] == 'c' || str[i] == 'd' ||
     str[i] == 'f' || str[i] == 'g' || str[i] == 'h' || str[i] == 'j' || str[i] == 'k' || str[i] == 'l' || str[i] == 'm' || str[i] == 'n' || 
     str[i] == 'p' || str[i] == 'q'|| str[i] == 'r' || str[i] == 's' || str[i] == 't' || str[i] == 'v' || str[i] == 'w' || str[i] == 'x' || str[i] == 'z')
    {
        System.Console.Write(str[i] + "");
    }
    Consonants(str, i+1);
}


System.Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
Consonants(str, 0);

// void Sogl(string str, int i)
// {
// if(i == str.Length)
// return;
// if(str[i] >= 'a' && str[i] <= 'z' && "aeiou".IndexOf(str[i]) == -1)
// {
// Console.Write(str[i]);
// }
// Sogl(str, i + 1);
// }


// string str = Console.ReadLine();
// Sogl(str, 0);
