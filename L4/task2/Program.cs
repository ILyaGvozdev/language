// сформировать двумерный массив из целых чисел и вывести на
// экран элементы, которые удовлетворяют некоторому критерию. Под этим
// критерием будем понимать чётность суммы цифр у числа.


int[,] CreateMatrix(int columnsCount, int rowsCount)
{
    int[,] matrix = new int[columnsCount,rowsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1,1000);
        }
    }
    return matrix;
}


bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits%2==0) return true;
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}



int[,] matrix = CreateMatrix(3,4);
ShowMatrix(matrix);
System.Console.WriteLine();

foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        System.Console.Write($"{e} "); 
    }
}

