using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int B = int.Parse(input[0]);
        int A = int.Parse(input[1]);

        while(B >= A)
        {
            Console.Write($"{B} ");
            B -= 2;
        }
    }
}
