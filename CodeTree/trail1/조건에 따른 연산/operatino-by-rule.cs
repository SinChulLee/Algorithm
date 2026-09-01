using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;

        while(true)
        {
            if (N >= 1000)
            {
                Console.Write(cnt);
                break;
            }
            if (N % 2 == 0)
                N = N * 3 + 1;
            else
                N = N * 2 + 2;
            cnt++;
        }
    }
}
