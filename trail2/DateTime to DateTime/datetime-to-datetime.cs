using System;

public class Codetree
{  
    public static int F(int a, int b, int c)
    {
        int stdminute = (11*24*60) + (11*60) + 11;
        int totalminute = (a*24*60) + (b*60) + c;
        if(stdminute > totalminute)
            return -1;
        return totalminute - stdminute;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        Console.Write(F(A,B,C));
    }
}
