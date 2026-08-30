using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;
        int prod = N;

        for (int i = 1; i <= N; i++)
        {
            prod /= i;
            cnt++;
            if (prod <= 1)
            {
                Console.Write(cnt);
                break;
            }
        }
    }
}
