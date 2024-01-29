int Fact(int n)
{
    int sum = 1;
    if(n==1 || n==0) return 1;
    System.Console.WriteLine($"{n}");
    int fa = n * Fact(n-1);
    System.Console.WriteLine(fa);
    return fa;
    
}

System.Console.Write(Fact(5));
 