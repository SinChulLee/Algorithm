using System;

public class Codetree
{  
    public static bool Judge(int m, int d)
    {
        int[] days = { 31, 28, 31, 30, 31, 30,
                   31, 31, 30, 31, 30, 31 };

        if(m > 12 || m < 1)
            return false;
        
        if(d < 1 || d > days[m-1])
            return false;
    
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int M = int.Parse(input[0]);
        int D = int.Parse(input[1]);
        if(Judge(M,D))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
