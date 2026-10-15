using System;

public class Codetree
{  
    public static void PrintResult(int a, char o, int c)
    {
        if(o == '+')
        {
            Console.Write($"{a} {o} {c} = {a+c}");
        }
        else if(o == '-')
        {
            Console.Write($"{a} {o} {c} = {a-c}");
        }
        else if(o == '/')
        {
            Console.Write($"{a} {o} {c} = {a/c}");
        }
        else if(o == '*')
        {
            Console.Write($"{a} {o} {c} = {a*c}");
        }
        else
        {
            Console.Write("False");
        }
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        char o = input[1][0];
        int c = int.Parse(input[2]);
        PrintResult(a,o,c);
    }
}
