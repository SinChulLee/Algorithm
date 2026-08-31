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
            if (N == 1)
            {
                Console.Write(cnt);
                break;
            }
            else if (N % 2 == 0)
            {
                N /= 2;
                cnt++;
            }
            else if (N % 2 == 1)
            {
                N = 3 * N + 1;
                cnt++;
            }

        }
    }
}
