using System;

public class Codetree
{  
    public static bool Isonjeonsu(int n)
    {
        if(n % 2 == 0)
            return false;
        if(n % 10 == 5)
            return false;
        if(n % 3 == 0 && n % 9 != 0)
            return false;
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
            if(Isonjeonsu(i))
                cnt++;
        }
        Console.Write(cnt);
    }
}
