using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int N = int.Parse(input[0]);
        int a = int.Parse(input[1]);

        int cnt = 1;

        while (cnt <= N)
        {
            if (cnt % a == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
            cnt++;
        }
    }
}
