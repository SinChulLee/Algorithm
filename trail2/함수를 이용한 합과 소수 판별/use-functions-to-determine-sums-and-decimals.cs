using System;

public class Codetree
{  
    public static bool Issosu(int n)
    {
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
                return false;
        }
        return true;
    }

    public static bool Istotalsum(int n)
    {
        int sum = 0;
        while(true)
        {
            if(n < 10)
            {
                sum += n;
                break;
            }
            sum += n % 10;
            n /= 10;
        }
        if(sum % 2 == 0)
            return true;
        else
            return false;
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
            if(Issosu(i) && Istotalsum(i))
                cnt++;
        }   
        Console.Write(cnt);
    }
}
