using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        for(int i = 0; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            char c = (char)num;
            Console.Write($"{c} ");
        }
    }
}
