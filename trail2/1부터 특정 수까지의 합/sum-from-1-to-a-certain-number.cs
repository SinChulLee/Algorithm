using System;

public class Codetree
{  
    public static int returndiv(int n)
    {
        int sum = 0;
        for(int i = 1; i <= n; i++)
            sum += i;
        
        return sum/10;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(returndiv(N));
    }   
}
