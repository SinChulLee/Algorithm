using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        bool satisfied = false;
    
        for (int i = a; i <= b; i++)
        {
            if (i % c == 0)
                satisfied = true;
        }
        if (satisfied)
            Console.Write("NO");
        else
            Console.Write("YES");
    }
}
