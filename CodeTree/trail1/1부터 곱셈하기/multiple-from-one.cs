using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int ans = 1;

        for (int i = 1; i <= 10; i++)
        {
            ans *= i;
            if (ans >= N)
            {
                Console.Write(i);
                break;
            }
        }
    }
}
