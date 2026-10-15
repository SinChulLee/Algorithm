using System;

public class Codetree
{  
    public static int PrintDouble(int a, int b)
    {
        int result = 1;
        for(int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        Console.Write(PrintDouble(a,b));
    }
}
