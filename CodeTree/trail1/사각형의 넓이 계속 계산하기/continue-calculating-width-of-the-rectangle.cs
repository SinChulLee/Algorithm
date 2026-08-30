using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int Width;
        int Length;

        while(true)
        {
            string[] input = Console.ReadLine().Split(' ');
            Width = int.Parse(input[0]);
            Length = int.Parse(input[1]);
            Console.WriteLine(Width * Length);
            if (input[2][0] == 'C')
                break;
        }
    }
}
