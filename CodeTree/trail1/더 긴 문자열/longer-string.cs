using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        string str1 = input[0];
        string str2 = input[1];

        if(str1.Length > str2.Length)
            Console.Write($"{str1} {str1.Length}");
        else if(str2.Length > str1.Length)
            Console.Write($"{str2} {str2.Length}");
        else
            Console.Write("same");
    }
}
