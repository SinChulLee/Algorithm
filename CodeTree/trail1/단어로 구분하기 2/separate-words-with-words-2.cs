using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        for(int i = 0; i < input.Length; i++)
        {
            if(i % 2 == 0)
                Console.WriteLine(input[i]);
        }
    }
}
