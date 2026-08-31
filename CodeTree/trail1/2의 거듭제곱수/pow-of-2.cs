using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;
        while (true)
        {
            if (N == 1)
            {
                Console.Write(cnt);
                break;
            }
            N /= 2;
            cnt++;
        }
    }
}
