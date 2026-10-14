using System;

public class Codetree
{  
    public static bool IsPrime(int n)
    {
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
                return false;
        }
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int cnt = 0;
        for(int i = A; i <= B; i++)
        {
            if(IsPrime(i))
                cnt += i;
        }
        Console.Write(cnt);
    }
}
